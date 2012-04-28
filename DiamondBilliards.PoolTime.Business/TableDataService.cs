using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.Linq;
using System.Text;
using DiamondBilliards.PoolTime.Data;

namespace DiamondBilliards.PoolTime.Business
{
    public static class TableDataService
    {
        public static TableStatus GetStatusByTableNum(int tableNum)
        {
            var poolTable = TablesDB.DataContext.PoolTables.Single(
                t => t.TableNum == tableNum);

            return poolTable.Status;
        }

        public static TableStatus[] GetAllTableStatus()
        {
            int NumTables;

            List<PoolTable> Tables = TablesDB.DataContext.PoolTables.ToList();
            NumTables = Tables.Count;
            TableStatus[] allTableStatus = new TableStatus[NumTables + 1];

            foreach (PoolTable table in Tables)
            {
                allTableStatus[table.TableNum] = table.Status;
            }

            return allTableStatus;
        }

        public static void SetStatusChangedHandler(int tableNum, EventHandler handler)
        {
            var poolTable = TablesDB.DataContext.PoolTables.Single(
            t => t.TableNum == tableNum);

            poolTable.StatusChangedHandler += handler;
        }

        public static void StartTable(int tableNum, DateTime startTime,
            List<string> players)
        {
            int numPlayers = players.Count;

            PoolTable table = null;

            table = TablesDB.DataContext.PoolTables.Single(t => t.TableNum == tableNum);
           
            foreach (string playerName in players)
            {
                PlayerDataService.AddPlayer(playerName, tableNum, numPlayers, startTime);
            }

            TablesDB.DataContext.SubmitChanges();

            UpdateTimestamps( table, startTime );

            TablesDB.DataContext.SubmitChanges();
        }

        public static void StopTable(PoolTable table)
        {
            List<Player> players = new List<Player>();

            foreach ( Player player in table.Players )
            {
                players.Add( player );
            }

            table.Players.Clear();

            foreach ( Player player in players )
            {
                PlayerDataService.DeletePlayer( player );
            }

            TablesDB.DataContext.SubmitChanges();
        }

        public static void StopTable( int tableNum )
        {
            PoolTable table = GetTableByNum( tableNum );

            List<Player> players = new List<Player>();

            foreach ( Player player in table.Players )
            {
                players.Add( player );
            }

            table.Players.Clear();

            foreach ( Player player in players )
            {
                PlayerDataService.DeletePlayer( player );
            }

            TablesDB.DataContext.SubmitChanges();
        }

        public static PoolTable GetTable(int tableNum)
        {
            return TablesDB.DataContext.PoolTables.Single(t => t.TableNum == tableNum);
        }

        public static PoolTable GetTableByNum( int tableNum )
        {
            return TablesDB.DataContext.PoolTables.Single( table => table.TableNum == tableNum );
        }

        public static int GetNumPlayers( int tableNum )
        {
            PoolTable table = TablesDB.DataContext.PoolTables.Single( t => t.TableNum == tableNum );

            return table.Players.Count;
        }

        public static void MovePlayers( List<int> playerIDs, int tableNum )
        {
            Player player = null;
            PoolTable newTable = TablesDB.DataContext.PoolTables.Single( t => t.TableNum == tableNum );
            DateTime timestamp = DateTime.Now;
            PoolTable oldTable = TablesDB.DataContext.Players.Single(
                p => p.ID == playerIDs.ElementAt(0)).PoolTable;
            List<string> newTableNames = PlayerNameFunctions.GetPlayerNames( newTable );

            foreach ( int playerID in playerIDs )
            {
                player = TablesDB.DataContext.Players.Single( p => p.ID == playerID );
                player.Name = PlayerNameFunctions.GetName( player.Name, newTableNames );
                player.PoolTable = newTable;

                newTableNames.Add( player.Name );
            }

            UpdateTimestamps( oldTable, timestamp );
            UpdateTimestamps( newTable, timestamp );

            TablesDB.DataContext.SubmitChanges();
        }

        public static void UpdateTimestamps( PoolTable table, DateTime timestamp)
        {
            if ( table.Players.Count > 0 )
            {
                int numPlayers = table.Players.Count;

                foreach ( Player player in table.Players )
                {
                    Timestamp newTimestamp = new Timestamp(
                        player.ID, table.TableNum, numPlayers, timestamp );

                    player.Timestamps.Add( newTimestamp );

                    TablesDB.DataContext.Timestamps.InsertOnSubmit( newTimestamp );
                }
            }
        }

        public static void StopAllTables()
        {
            foreach ( PoolTable table in TablesDB.DataContext.PoolTables )
            {
                StopTable( table );
            }

            TablesDB.DataContext.SubmitChanges();
        }

        public static DateTime GetStartTime( PoolTable table )
        {
            var players = from player in table.Players
                          orderby player.StartTime
                          select new { StartTime = player.StartTime };

            return players.First().StartTime;
        }

        public static void ChangeTableStartTime( PoolTable _table, DateTime newStartTime, DateTime currentTime )
        {
            if ( newStartTime <= currentTime )
            {

                foreach ( Player player in _table.Players )
                {
                    var oldTimestamps = from timestamp in player.Timestamps
                                        where timestamp.StartTime <= newStartTime
                                        select timestamp;

                    if ( oldTimestamps != null )
                    {
                        for ( int i = 0; i < oldTimestamps.Count(); i++ )
                        {
                            TimestampDataService.DeleteTimestamp( oldTimestamps.First() );
                        }
                    }

                    var otherTableTimestamps = from timestamp in player.Timestamps
                                     where timestamp.TableNum != _table.TableNum
                                     select timestamp;

                    if ( otherTableTimestamps != null )
                    {
                        for ( int i = 0; i < otherTableTimestamps.Count(); i++ )
                        {
                            TimestampDataService.DeleteTimestamp( otherTableTimestamps.First() );
                        }
                    }

                    var timestamps = from timestamp in player.Timestamps
                                     orderby timestamp.StartTime
                                     select timestamp;

                    if ( timestamps != null )
                    {
                        timestamps.First().StartTime = newStartTime;
                    }

                    PlayerDataService.SetPlayerStartTime( player );
                }

                TablesDB.DataContext.SubmitChanges();
            } else
            {
                throw new Exception( "Woops! Player's start time must be in the past..." );
            }
        }

        public static int GetNumActiveTables()
        {
            int numActiveTables = 0;

            foreach ( PoolTable table in TablesDB.DataContext.PoolTables )
            {
                if ( table.Status == TableStatus.Active )
                {
                    numActiveTables++;
                }
            }

            return numActiveTables;
        }

        public static int GetNumTables()
        {
            return TablesDB.DataContext.PoolTables.Count();
        }

        public static int GetNumPlayers()
        {
            return TablesDB.DataContext.Players.Count();
        }
    }
}
