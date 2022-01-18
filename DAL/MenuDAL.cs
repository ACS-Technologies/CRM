using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class MenuDAL : Database
    {
        SqlCommand cmd;
        /// <summary>
        /// D_Menu_Get
        /// </summary>
        /// <returns></returns>
        public DataSet D_Menu_Get()
        {
            cmd = new SqlCommand();
            cmd.CommandText = "D_Menu_Get";

            return ExDataBase_returnDataSet(cmd);
        }

    }
}