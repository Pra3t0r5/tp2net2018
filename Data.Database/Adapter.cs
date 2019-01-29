using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace Data.Database
{
    public class Adapter
    {
        const string consKeyDefaultCnnString = "ConnStringLocal";

        public SqlConnection SqlConn { get; set; }

        protected void OpenConnection()
        {
           string conectionstring = ConfigurationManager.ConnectionStrings[consKeyDefaultCnnString].ConnectionString;
            SqlConn = new SqlConnection(conectionstring);
            SqlConn.Open();

        }

        protected void CloseConnection()
        {
            SqlConn.Close();
        }

    
    }
}
