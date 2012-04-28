using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DiamondBilliards.PoolTime.Data;

namespace DiamondBilliards.PoolTime.Business
{
    public static class PlayerDataService
    {
        public static Player AddPlayer(string playerName, int tableNum, int numPlayers, DateTime startTime)
        {
            PoolTable table = TableDataService.GetTable(tableNum);
            Player newPlayer = new Player(tableNum, playerName, startTime);
            table.Players.Add(newPlayer);
            TablesDB.DataContext.Players.InsertOnSubmit(newPlayer);

            return newPlayer;
        }

        public static void SetPlayerStartTime( Player player )
        {
            var timestamps = from timestamp in player.Timestamps
                             orderby timestamp.StartTime
                             select new { StartTime = timestamp.StartTime };

            player.StartTime = timestamps.First().StartTime;
        }

        public static void DeletePlayer(int playerID)
        {
            Player player = GetPlayerByID(playerID);

            player.PoolTable = null;

            if ( player.Timestamps.Count > 0 )
            {
                foreach ( Timestamp timestamp in player.Timestamps )
                {
                    TablesDB.DataContext.Timestamps.DeleteOnSubmit( timestamp );
                }
            }

            TablesDB.DataContext.Players.DeleteOnSubmit(player);
        }

        public static void DeletePlayer( Player player )
        {
            player.PoolTable = null;

            if ( player.Timestamps.Count > 0 )
            {
                foreach ( Timestamp timestamp in player.Timestamps )
                {
                    TablesDB.DataContext.Timestamps.DeleteOnSubmit( timestamp );
                }
            }

            TablesDB.DataContext.Players.DeleteOnSubmit( player );
        }

        public static Player GetPlayerByID(int playerID)
        {
            return TablesDB.DataContext.Players.Single(p => p.ID == playerID);
        }

        public static void ChangePlayerStartTime( Player player, DateTime newStartTime, DateTime currentTime )
        {
            Timestamp timestamp = null;
            
            IOrderedEnumerable<Timestamp> timestamps = player.Timestamps.OrderBy( t => t.ID );
            Timestamp[] timestampArr = timestamps.ToArray();
            int numTimestamps = timestampArr.Length;

            if ( newStartTime <= currentTime )
            {
                if ( numTimestamps > 1 )
                {
                    for ( int i = 1; i < numTimestamps; i++ )
                    {
                        timestamp = timestampArr[i];

                        if ( newStartTime >= timestamp.StartTime )
                        {
                            TimestampDataService.DeleteTimestamp( timestampArr[i - 1] );
                        }
                    }
                }

                IOrderedEnumerable<Timestamp> newTimestamps = player.Timestamps.OrderBy( t => t.ID );
                Timestamp firstTimestamp = newTimestamps.First();
                firstTimestamp.StartTime = newStartTime;
                firstTimestamp.Player.StartTime = newStartTime;

                TablesDB.DataContext.SubmitChanges();
            } else
            {
                throw new Exception( "Woops! Player's start time must be in the past..." );
            }
        }
    }
}