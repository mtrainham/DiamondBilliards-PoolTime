using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DiamondBilliards.PoolTime.Data;

namespace DiamondBilliards.PoolTime.Business
{
    public static class TimestampDataService
    {
        public static Timestamp GetTimestampByID( int timestampID )
        {
            return TablesDB.DataContext.Timestamps.Single( timestamp => timestamp.ID == timestampID );
        }

        public static void DeleteTimestamp( Timestamp timestamp )
        {
            timestamp.Player.Timestamps.Remove( timestamp );
            TablesDB.DataContext.Timestamps.DeleteOnSubmit( timestamp );
        }
    }
}
