using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace DiamondBilliards.PoolTime.Data
{
    public class SqlDBConnection
    {
        private string strConnection = "|DataDirectory|PoolTime.sdf";
                
        private SqlConnection connection;

        internal SqlDBConnection()
        {
            OpenDBConnection();
        }

        internal void OpenDBConnection()
        {
            connection = new SqlConnection(strConnection);
            connection.Open();
        }

        internal void CloseDBConnection()
        {
            connection.Close();
            connection.Dispose();
        }

        internal void ExecuteQuery( string sqlQuery )
        {
            SqlCommand command = new SqlCommand(sqlQuery, connection);

            command.ExecuteNonQuery();
        }
    }
}
