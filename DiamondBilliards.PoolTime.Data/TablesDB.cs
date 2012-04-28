using System;
using System.Collections.Generic;
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
            _dataContext = new PoolTimeDataContext();
        }
    }
}
