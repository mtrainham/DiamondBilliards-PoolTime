using System;
using System.Collections.Generic;
using System.Linq;
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
            PoolTable table = null;

            table = TablesDB.DataContext.PoolTables.Single(t => t.TableNum == tableNum);

           
            foreach (string playerName in players)
            {
                PlayerDataService.AddPlayer(tableNum, playerName, startTime);
            }
        }

        public static void ResetTable(int tableNum)
        {
            PoolTable table = GetTable(tableNum);

            table.Players.Clear();

            TablesDB.DataContext.SubmitChanges();
        }

        public static PoolTable GetTable(int tableNum)
        {
            return TablesDB.DataContext.PoolTables.Single(t => t.TableNum == tableNum);
        }
    }
}
