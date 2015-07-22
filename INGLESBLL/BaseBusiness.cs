using System;
using System.Configuration;
using FirebirdSql.Data.FirebirdClient;

namespace InglesBLL
{
    public class BaseBusiness
    {
        private static string stringConexion = string.Empty;
        /// <summary>
        /// Representa 
        /// </summary>
        public static string _StringConexion
        {
            get
            {
                FbConnectionStringBuilder csb = new FbConnectionStringBuilder();
                csb.ServerType = FbServerType.Embedded;                
                csb.UserID = ConfigurationManager.AppSettings["USERID"];
                csb.Password = ConfigurationManager.AppSettings["PASSWORD"];
                csb.Dialect = Convert.ToInt32(ConfigurationManager.AppSettings["DIALECT"]);
                csb.Database = ConfigurationManager.AppSettings["DATABASE"];
                csb.Charset = ConfigurationManager.AppSettings["CHARSET"];
                stringConexion = csb.ConnectionString;
                return stringConexion;
            }
        }
    }
}
