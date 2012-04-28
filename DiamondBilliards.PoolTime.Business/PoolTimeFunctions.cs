using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DiamondBilliards.PoolTime.Data;

namespace DiamondBilliards.PoolTime.Business
{
    public static class PoolTimeFunctions
    {
        public static decimal CalcTablePoolTime( int tableNum, DateTime endTime )
        {
            decimal total = 0.0M;
            PoolTable table = TableDataService.GetTable( tableNum );

            if ( table.Players.Count > 0 )
            {
                foreach ( Player player in table.Players )
                {
                    total += CalcPlayerPoolTime( player, endTime );
                }
            }

            return total;
        }

        public static decimal CalcTablePoolTime( PoolTable table, DateTime endTime )
        {
            decimal total = 0.0M;
           
            if ( table.Players.Count > 0 )
            {
                foreach ( Player player in table.Players )
                {
                    total += CalcPlayerPoolTime( player, endTime );
                }
            }

            return total;
        }

        public static double CalcTotalTableHours( PoolTable table, DateTime endTime )
        {
            double total = 0.0;

            if ( table.Players.Count > 0 )
            {
                var players = from player in table.Players
                              orderby player.StartTime
                              select player;

                Player[] playersArr = players.ToArray();

                DateTime startTime = playersArr[0].StartTime;

                if ( startTime <= endTime )
                {
                    total = ( endTime - startTime ).TotalHours;
                } else
                {
                    total = 0.0;
                }
            }

            return total;
        }

        public static double CalcTotalPlayerHours( Player player, DateTime endTime )
        {
            double total = 0.0;

            if ( player.Timestamps.Count > 0 )
            {
                DateTime stopTime;

                var orderedTimestamps = from timestamp in player.Timestamps
                                        orderby timestamp.StartTime
                                        select timestamp;
                
                Timestamp[] timestampArr = orderedTimestamps.ToArray();

                for ( int i = 0; i < timestampArr.Length; i++ )
                {
                    DateTime startTime = timestampArr[i].StartTime;

                    if ( i < timestampArr.Length - 1 )
                    {
                        stopTime = timestampArr[i + 1].StartTime;
                    } else
                    {
                        stopTime = endTime;
                    }

                    if ( startTime <= stopTime )
                    {
                        total += ( stopTime - startTime ).TotalHours;
                    } else
                    {
                        total += 0;
                    }
                }
            }

            return total;
        }

        public static decimal CalcPlayerPoolTime( Player player, DateTime endTime )
        {
            decimal total = 0.0M;

            if ( player.Timestamps.Count > 0 )
            {
                var orderedTimestamps = from timestamp in player.Timestamps
                                        orderby timestamp.StartTime
                                        select timestamp;
                
                Timestamp[] timestampArr = orderedTimestamps.ToArray();

                for ( int i = 0; i < timestampArr.Length; i++ )
                {
                    int numPlayers = timestampArr[i].NumPlayers;
                    DateTime startTime = timestampArr[i].StartTime;
                    DateTime stopTime;
                    decimal ratePerHour = GetHourlyPlayerRate( numPlayers );

                    if ( i < timestampArr.Length - 1 )
                    {
                        stopTime = timestampArr[i + 1].StartTime;
                    } else
                    {
                        stopTime = endTime;
                    }

                    total += CalcPoolTime( startTime, stopTime, ratePerHour );
                }
            }

            return total;
        }

        public static decimal CalcPlayerPoolTime( int playerID, DateTime endTime )
        {
            Player player = PlayerDataService.GetPlayerByID( playerID );

            decimal total = 0.0M;

            if ( player.Timestamps.Count > 0 )
            {
                var orderedTimestamps = from timestamp in player.Timestamps
                                        orderby timestamp.StartTime
                                        select timestamp;

                Timestamp[] timestampArr = orderedTimestamps.ToArray();

                for ( int i = 0; i < timestampArr.Length; i++ )
                {
                    int numPlayers = timestampArr[i].NumPlayers;
                    DateTime startTime = timestampArr[i].StartTime;
                    DateTime stopTime;
                    decimal ratePerHour = GetHourlyPlayerRate( numPlayers );

                    if ( i < timestampArr.Length - 1 )
                    {
                        stopTime = timestampArr[i + 1].StartTime;
                    } else
                    {
                        stopTime = endTime;
                    }

                    total += CalcPoolTime( startTime, stopTime, ratePerHour );
                }
            }

            return total;
        }

        public static decimal CalcPoolTime( DateTime startTime, DateTime stopTime, 
            decimal ratePerHour )
        {
            TimeSpan netTime;

            if ( startTime > stopTime )
            {
                return 0.0M;
            }

            netTime = stopTime - startTime;

            return ratePerHour * Convert.ToDecimal( netTime.TotalHours );
        }

        public static decimal GetHourlyPlayerRate( int numPlayers )
        {
            switch ( numPlayers )
            {
                case 0:
                    return 0.0M;
                case 1:
                    return 4.0M;
                case 2:
                    return 3.5M;
                default:
                    return 10.0M / Convert.ToDecimal( numPlayers );
            }
        }

        public static decimal GetHourlyTableRate( int numPlayers )
        {
            switch ( numPlayers )
            {
                case 0:
                    return 0.0M;
                case 1:
                    return 3.0M;
                case 2:
                    return 5.0M;
                default:
                    return 8.0M;
            }
        }

        public static decimal CalcTotalPoolTime(DateTime currentTime)
        {
            decimal totalAmount = 0.0M;

            foreach ( Player player in TablesDB.DataContext.Players )
            {
                totalAmount += CalcPlayerPoolTime( player, currentTime );
            }

            return totalAmount;
        }
    }
}
