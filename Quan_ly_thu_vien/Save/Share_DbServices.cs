using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace Save
{
    public class Share_DbServices
    {
        public SqlConnection con;

        public Share_DbServices()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString);
        }
        public static string type;
        
    }
}
