using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;

namespace DiamondBilliards.PoolTime.Data
{
    public class TablesDB
    {
        private static PoolTimeDataContext _dataContext = null;

        public static PoolTimeDataContext DataContext
        {
            get { return _dataContext; }
        }

        static TablesDB()
        {
          var connectionString = "Data Source=|DataDirectory|PoolTime.sdf";

          //var engine = new SqlCeEngine(connectionString);
          //
          //engine.Upgrade();

          var conn = new SqlCeConnection(connectionString);

          _dataContext = new PoolTimeDataContext(conn);
        }
    }
}
