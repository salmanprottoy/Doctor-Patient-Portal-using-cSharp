using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Doctor_Patient_Portal
{
    class DataAccess
    {
        private SqlConnection myConnection;
        private SqlCommand myCommand;

        public DataAccess()
        {
            string connectionString = @"Data Source=SALMAN-PC\SQLEXPRESS;Initial Catalog=12;Integrated Security=True";
            myConnection = new SqlConnection(connectionString);
        }

        public void ConnectWithDB()
        {
            myConnection.Open();
        }
        public void CloseConnection()
        {
            myConnection.Close();
        }

        public SqlDataReader GetData(string query)
        {
            myCommand = new SqlCommand(query, myConnection);
            return myCommand.ExecuteReader();
        }
        public int ExecuteSQL(string query)
        {
            myCommand = new SqlCommand(query, myConnection);
            return myCommand.ExecuteNonQuery();
        }
    }
}
