using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DITApi.Config.Gateway
{
    public class DatabaseGateway
    {
        private string conncetionString = "server=tcp:Dit-app.databse.windows.net,1433; Databse=DitAppV1;user ID = Ditapp; Password=MVPR0ck*;Trusted_Connection=False; Encrypt=True;";
        public SqlConnection connection;
        public DatabaseGateway()
        {
            connection = new SqlConnection(conncetionString);
            try
            {
                connection.Open();
                Debug.WriteLine("databse connected");
            }
            catch
            {
                Debug.WriteLine("");
            }
            finally
            {

            }

        }
    }
}
