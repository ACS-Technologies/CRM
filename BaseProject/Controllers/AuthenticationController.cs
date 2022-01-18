using System.Collections.Generic;
using System.Linq;
using System;
using System.Web;
using System.Web.Mvc;
using BaseProject.Models;
using BaseProject.CORS;
using BaseProject.Utilities;
using Newtonsoft.Json;
using System.Configuration;
using DBL;
using POCO;

namespace BaseProject.Controllers
{
    [AllowCrossSite]
    public class AuthenticationController : Controller
    {
        #region Varibles

        private User oUser;
        private MenuDBL omenuDBL;
        private Menu omenu;
        private List<Menu> Secondarylist, Primarylist;

        #endregion

        #region Actions
        // GET: Authentication
        public ActionResult Index()
        {
            if (Request.Cookies["Remember"] == null || Request.Cookies["Remember"].Value == "")
            {
                return View();
            }
            else
            {
                omenuDBL = new MenuDBL();
                Secondarylist = new List<Menu>();
                Primarylist = new List<Menu>();
                string language;
                if (Request.Cookies["Language"] != null)
                {
                    language = Request.Cookies["Language"].Value;
                }
                else
                {
                    language = "en";
                }

                Secondarylist = omenuDBL.D_SecondaryMenu_Get(language).ToList();
                Primarylist = omenuDBL.D_PrimaryMenu_Get(language).ToList();
                Session["PrimaryMenuList"] = Primarylist;
                Session["SecondaryMenuList"] = Secondarylist;
                System.Web.HttpContext.Current.Session["FromIframe"] = "";
                return RedirectToAction("SelectCompany");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(User PoUser)
        {
            oUser = new User();
            omenuDBL = new MenuDBL();
            omenu = new Menu();
            Secondarylist = new List<Menu>();
            Primarylist = new List<Menu>();

            string language;
            try
            {
                if (Request.Cookies["Language"] != null)
                {
                    language = Request.Cookies["Language"].Value;
                }
                else
                {
                    language = "en";
                }
                //API 
                APIAuthorization authorization = APICall.GetAuthorization(string.Format("{0}/token", (object)ConfigurationManager.AppSettings["APIAuthenticationURL"]), ConfigurationManager.AppSettings["APIUser"], ConfigurationManager.AppSettings["APIPassword"]);
                Response response = APICall.Post<Response>(string.Format("{0}/Users/LogIn", (object)ConfigurationManager.AppSettings["APIAuthenticationURL"]), authorization.TokenType, authorization.AccessToken, PoUser);
                if (response.IsScusses)
                {
                    oUser = JsonConvert.DeserializeObject<POCO.User>(JsonConvert.SerializeObject(response.ResponseDetails));
                }

                if (oUser == null)
                {
                    ModelState.AddModelError(string.Empty, "Invalid username or password");
                    return View("index");
                }
                else
                {

                    Secondarylist = omenuDBL.D_SecondaryMenu_Get(language);
                    Primarylist = omenuDBL.D_PrimaryMenu_Get(language);

                    Session["PrimaryMenuList"] = Primarylist;
                    Session["SecondaryMenuList"] = Secondarylist;
                    Session["UserInfo"] = oUser;
                    Session["Role"] = oUser.Role_Id.ToString();

                    HttpCookie cookie = new HttpCookie("Remember");
                    cookie.Value = oUser.UserID.ToString();
                    Response.Cookies.Add(cookie);

                    return RedirectToAction("SelectCompany");

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public ActionResult Logout()
        {
            try
            {
                Response.Cookies["Remember"].Value = "";
                Response.Cookies["Remember"].Expires = DateTime.Now.AddDays(-1);

                Session.Clear();

                Session.Abandon();
                Session.RemoveAll();

                return RedirectToAction("Index", "Authentication");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ActionResult SelectCompany()
        {
            if (SessionManager.GetSessionUserInfo.UserID > 0)
            {
                List<CompanyInfo> oLCompanyInfo = new List<CompanyInfo>();
                //API 
                APIAuthorization authorization = APICall.GetAuthorization(string.Format("{0}/token", (object)ConfigurationManager.AppSettings["APIURL"]), ConfigurationManager.AppSettings["APIUser"], ConfigurationManager.AppSettings["APIPassword"]);
                Response response = APICall.Get<Response>(string.Format("{0}/Authentication/Companies?UserId={1}", (object)ConfigurationManager.AppSettings["APIURL"], SessionManager.GetSessionUserInfo.UserID), authorization.TokenType, authorization.AccessToken);
                if (response.IsScusses)
                {
                    oLCompanyInfo = JsonConvert.DeserializeObject<List<CompanyInfo>>(JsonConvert.SerializeObject(response.ResponseDetails));
                }
                return View(oLCompanyInfo);
            }
            else
            {
                return RedirectToAction("Logout");
            }
        }

        public ActionResult SelectCompanyLink(int Company)
        {
            //API 
            APIAuthorization authorization = APICall.GetAuthorization(string.Format("{0}/token", (object)ConfigurationManager.AppSettings["APIURL"]), ConfigurationManager.AppSettings["APIUser"], ConfigurationManager.AppSettings["APIPassword"]);
            Response response = APICall.Get<Response>(string.Format("{0}/Authentication/CompaniesLink?CompanyId={1}", (object)ConfigurationManager.AppSettings["APIURL"], Company), authorization.TokenType, authorization.AccessToken);
            if (response.IsScusses)
            {
                Session["CompanyInfo"] = JsonConvert.DeserializeObject<CompanyInfo>(JsonConvert.SerializeObject(response.ResponseDetails));
            }
            Session["Company"] = Company;
            return RedirectToAction("SelectBranch");
        }
        //     [MyAuthorize]
        public ActionResult SelectBranch()
        {
            List<Branches> oLbranches = new List<Branches>();
            int comapnyId = int.Parse(Session["Company"].ToString());
            //API 
            APIAuthorization authorization = APICall.GetAuthorization(string.Format("{0}/token", (object)ConfigurationManager.AppSettings["APIURL"]), ConfigurationManager.AppSettings["APIUser"], ConfigurationManager.AppSettings["APIPassword"]);
            Response response = APICall.Get<Response>(string.Format("{0}/Authentication/Branches?CompanyId={1}", (object)ConfigurationManager.AppSettings["APIURL"], comapnyId), authorization.TokenType, authorization.AccessToken);
            if (response.IsScusses)
            {
                oLbranches = JsonConvert.DeserializeObject<List<Branches>>(JsonConvert.SerializeObject(response.ResponseDetails));
            }
            return View(oLbranches);
        }

        public ActionResult SelectBranchLink(int branch)
        {
            int comapnyId = int.Parse(Session["Company"].ToString());

            string language;
            if (Request.Cookies["Language"] != null)
            {
                language = Request.Cookies["Language"].Value;
            }
            else
            {
                language = "en";
            }

            //API 
            APIAuthorization authorization = APICall.GetAuthorization(string.Format("{0}/token", (object)ConfigurationManager.AppSettings["APIURL"]), ConfigurationManager.AppSettings["APIUser"], ConfigurationManager.AppSettings["APIPassword"]);
            Response response = APICall.Get<Response>(string.Format("{0}/Authentication/BranchesLink?BranchId={1}", (object)ConfigurationManager.AppSettings["APIURL"], branch), authorization.TokenType, authorization.AccessToken);
            if (response.IsScusses)
            {
                Session["branchInfo"] = JsonConvert.DeserializeObject<Branches>(JsonConvert.SerializeObject(response.ResponseDetails));
            }
            Session["branch"] = branch;
            var s = Session["branchInfo"];
            var userId = SessionManager.GetSessionUserInfo.UserID;
            string permission = "";
            APIAuthorization permissionAuthorization = APICall.GetAuthorization(string.Format("{0}/token", (object)ConfigurationManager.AppSettings["APIAuthenticationURL"]), ConfigurationManager.AppSettings["APIUser"], ConfigurationManager.AppSettings["APIPassword"]);
            Response permissionResponse = APICall.Get<Response>(string.Format("{0}/Users/GetUserPermission?userId={1}&ModuleId={2}&companyId={3}&branchId={4}", (object)ConfigurationManager.AppSettings["APIAuthenticationURL"], Models.SessionManager.GetSessionUserInfo.UserID, 2, comapnyId, branch), permissionAuthorization.TokenType, permissionAuthorization.AccessToken);
            if (permissionResponse.IsScusses)
            {
                permission = JsonConvert.DeserializeObject<string>(JsonConvert.SerializeObject(permissionResponse.ResponseDetails));
            }
            Session["Permission"] = permission;

            return RedirectToAction("Index", "Dashboard");
        }


        public ActionResult SelectModules()
        {
            return View();
        }

        #endregion

    }
}