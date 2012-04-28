using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DiamondBilliards.PoolTime.Data;

namespace DiamondBilliards.PoolTime.Business
{
    public static class DBCheck
    {
        public static bool IsWorking()
        {
            if ( TablesDB.DataContext.DatabaseExists() )
            {
                return true; // database exists and is connected
            } else
            {
                return false; // database connection failed
            } 
        } 
    }
}
