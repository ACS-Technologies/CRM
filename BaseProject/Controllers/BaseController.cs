using BaseProject.CORS;
using POCO;
using System;
using System.Web.Mvc;
using System.IO;
using BaseProject.Models;
using System.Net.Mail;
using System.Net;

namespace BaseProject.Controllers
{
    [AllowCrossSite]
    public class BaseController : Controller
    {

        #region Varibles
        #endregion

        public BaseController()
        {

        }

        #region Actions       
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            try
            {

                var userId = SessionManager.GetSessionUserInfo.UserID;

                // If session exists
                if (filterContext.HttpContext.Session["UserInfo"] == null)
                {
                    //redirect to desired session
                    //expiration action and controller
                    filterContext.Result = this.Redirect("~/Authentication/Index?BURL=" + HttpContext.Request.Path);
                    return;
                }

                if (userId == 0)
                {
                    //redirect to desired session
                    //expiration action and controller
                    filterContext.Result = this.Redirect("~/Authentication/Index?BURL=" + HttpContext.Request.Path);
                    return;
                }
                //otherwise continue with action
                base.OnActionExecuting(filterContext);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        #endregion
    }
}