using POCO;
using System.Collections.Generic;
using System.Web;


namespace BaseProject.Models
{
    public static class SessionManager
    {
        public static User GetSessionUserInfo
        {
            get
            {
                //store the object in session if not already stored
                if (HttpContext.Current.Session["UserInfo"] == null)
                    HttpContext.Current.Session["UserInfo"] = new User();

                //return the object from session
                return (User)HttpContext.Current.Session["UserInfo"];
            }
        }


        public static User SetSessionUserInfo
        {
            set
            {
                HttpContext.Current.Session["UserInfo"] = value;
            }
        }
        /*********Menu*********/
        public static Menu GetSessionPrimaryMenuInfo
        {
            get
            {
                //store the object in session if not already stored
                if (HttpContext.Current.Session["PrimaryMenuList"] == null)
                    HttpContext.Current.Session["PrimaryMenuList"] = new Menu();

                //return the object from session
                return (Menu)HttpContext.Current.Session["PrimaryMenuList"];
            }
        }

        public static List<Menu> GetSessionPrimaryMenuListInfo
        {
            get
            {
                //store the object in session if not already stored
                if (HttpContext.Current.Session["PrimaryMenuList"] == null)
                    HttpContext.Current.Session["PrimaryMenuList"] = new List<Menu>();

                //return the object from session
                return (List<Menu>)HttpContext.Current.Session["PrimaryMenuList"];
            }
        }

        public static Menu SetSessionPrimaryMenuInfo
        {
            set
            {
                HttpContext.Current.Session["PrimaryMenuList"] = value;
            }
        }

        public static Menu GetSessionSecondaryMenuInfo
        {
            get
            {
                //store the object in session if not already stored
                if (HttpContext.Current.Session["SecondaryMenuList"] == null)
                    HttpContext.Current.Session["SecondaryMenuList"] = new Menu();

                //return the object from session
                return (Menu)HttpContext.Current.Session["SecondaryMenuList"];
            }
        }

        public static List<Menu> GetSessionSecondaryMenuListInfo
        {
            get
            {
                //store the object in session if not already stored
                if (HttpContext.Current.Session["SecondaryMenuList"] == null)
                    HttpContext.Current.Session["SecondaryMenuList"] = new List<Menu>();

                //return the object from session
                return (List<Menu>)HttpContext.Current.Session["SecondaryMenuList"];
            }
        }

        public static Menu SetSessionSecondaryMenuInfo
        {
            set
            {
                HttpContext.Current.Session["SecondaryMenuList"] = value;
            }
        }

        /***Company****/
        public static CompanyInfo GetSessionCompanyInfo
        {
            get
            {
                //store the object in session if not already stored
                if (HttpContext.Current.Session["CompanyInfo"] == null)
                    HttpContext.Current.Session["CompanyInfo"] = new CompanyInfo();

                //return the object from session
                return (CompanyInfo)HttpContext.Current.Session["CompanyInfo"];
            }
        }


        public static CompanyInfo SetSessionCompanyInfo
        {
            set
            {
                HttpContext.Current.Session["CompanyInfo"] = value;
            }
        }

    }
}