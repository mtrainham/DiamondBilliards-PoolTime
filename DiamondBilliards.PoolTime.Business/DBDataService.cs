using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiamondBilliards.PoolTime.Data
{
    public static class DBDataService
    {
        public static void ResetDB()
        {
            try
            {
                string strSqlCommand = string.Empty;

                // reset Players table....

                strSqlCommand = "DROP TABLE Players";

                TablesDB.DataContext.ExecuteCommand( strSqlCommand );

                TablesDB.DataContext.SubmitChanges();

                strSqlCommand = "CREATE TABLE Players (PlayerID int IDENTITY PRIMARY KEY, TableNum int, Name nvarchar(50), StartTime datetime, Status int)";

                TablesDB.DataContext.ExecuteCommand( strSqlCommand );

                TablesDB.DataContext.SubmitChanges();

                // reset Timestamps table...

                strSqlCommand = "DROP TABLE Timestamps";

                TablesDB.DataContext.ExecuteCommand( strSqlCommand );

                TablesDB.DataContext.SubmitChanges();

                strSqlCommand = "CREATE TABLE Timestamps (TimestampID int IDENTITY PRIMARY KEY, PlayerID int, TableNum int, StartTime datetime, NumPlayers int)";

                TablesDB.DataContext.ExecuteCommand( strSqlCommand );

                TablesDB.DataContext.SubmitChanges();
            }

            catch
            {
                throw new Exception( "An error occurred attempting to reset the database" );
            }
        }
    }
}
