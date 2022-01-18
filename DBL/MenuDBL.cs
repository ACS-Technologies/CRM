using DAL;
using POCO;
using System;
using System.Collections.Generic;
using System.Data;

namespace DBL
{
    public class MenuDBL
    {
        MenuDAL oMenuDAL = new MenuDAL();
        private Menu omenu;
        DataSet ds;
        /// <summary>
        /// D_PrimaryMenu_Get
        /// </summary>
        /// <param name="language"></param>
        /// <returns>List<Menu></returns>
        public List<Menu> D_PrimaryMenu_Get(string language)
        {
            List<Menu> OLMenu = new List<Menu>();
            ds = oMenuDAL.D_Menu_Get();

            if (ds.Tables.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    omenu = new Menu();
                    omenu.MenuId = Convert.ToInt32(ds.Tables[0].Rows[i]["MenuId"]);
                    omenu.ParentId = Convert.ToInt64(ds.Tables[0].Rows[i]["ParentId"]);
                    omenu.PrimaryName = ds.Tables[0].Rows[i]["PrimaryName"].ToString();
                    omenu.Icon = ds.Tables[0].Rows[i]["Icon"].ToString();
                    omenu.ControllerName = ds.Tables[0].Rows[i]["ControllerName"].ToString();
                    omenu.MethodName = ds.Tables[0].Rows[i]["MethodName"].ToString();
                    omenu.Parameter = ds.Tables[0].Rows[i]["Parameter"].ToString();


                    OLMenu.Add(omenu);
                }
            }
            return OLMenu;
        }
        /// <summary>
        /// D_SecondaryMenu_Get
        /// </summary>
        /// <param name="language"></param>
        /// <returns>List<Menu></returns>
        public List<Menu> D_SecondaryMenu_Get(string language)
        {
            List<Menu> OLMenu = new List<Menu>();
            ds = oMenuDAL.D_Menu_Get();

            if (ds.Tables.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    omenu = new Menu();
                    omenu.MenuId = Convert.ToInt32(ds.Tables[0].Rows[i]["MenuId"]);
                    omenu.ParentId = Convert.ToInt64(ds.Tables[0].Rows[i]["ParentId"]);
                    omenu.PrimaryName = ds.Tables[0].Rows[i]["SecondarName"].ToString();
                    omenu.Icon = ds.Tables[0].Rows[i]["Icon"].ToString();
                    omenu.ControllerName = ds.Tables[0].Rows[i]["ControllerName"].ToString();
                    omenu.MethodName = ds.Tables[0].Rows[i]["MethodName"].ToString();
                    omenu.Parameter = ds.Tables[0].Rows[i]["Parameter"].ToString();

                    OLMenu.Add(omenu);
                }
            }
            return OLMenu;
        }
    }
}
