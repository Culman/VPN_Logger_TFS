using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Xml.Linq;
using System.Configuration;

namespace TFS_VPN_Logger
{
    class SQLFactory
    {

        public void WriteToDB(string document)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["sqlconnection"]))
            {
                using (SqlCommand command = new SqlCommand("dbo.AppDataInput", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@input", System.Data.SqlDbType.Xml).Value = document;
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                }
            }


        }

    }
}
