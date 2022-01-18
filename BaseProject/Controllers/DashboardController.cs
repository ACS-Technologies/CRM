using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaseProject.Controllers
{
    public class DashboardController : BaseController
    {
        #region Variables
        #endregion

        #region Action

        // GET: Dashboard
        public ActionResult Index()
        {

            return View();
        }
        #endregion
    }
}
