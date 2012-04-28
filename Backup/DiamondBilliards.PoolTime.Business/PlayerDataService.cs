using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DiamondBilliards.PoolTime.Data;

namespace DiamondBilliards.PoolTime.Business
{
    public static class PlayerDataService
    {
        public static void AddPlayer(int tableNum, string name, DateTime startTime)
        {
            PoolTable table = TableDataService.GetTable(tableNum);
            Player newPlayer = new Player(tableNum, name, startTime);
            table.Players.Add(newPlayer);
            TablesDB.DataContext.Players.InsertOnSubmit(newPlayer);
            TablesDB.DataContext.SubmitChanges();

            Timestamp newTimestamp = new Timestamp(newPlayer.ID, tableNum, startTime);
            newPlayer.Timestamps.Add(newTimestamp);
            TablesDB.DataContext.Timestamps.InsertOnSubmit(newTimestamp);
            TablesDB.DataContext.SubmitChanges();
        }

        public static void DeletePlayer(int playerID)
        {
            Player player = GetPlayerByID(playerID);

            foreach (Timestamp timestamp in player.Timestamps)
            {
                TablesDB.DataContext.Timestamps.DeleteOnSubmit(timestamp);
            }

            TablesDB.DataContext.Players.DeleteOnSubmit(player);
        }

        public static Player GetPlayerByID(int playerID)
        {
            return TablesDB.DataContext.Players.Single(p => p.ID == playerID);
        }
    }
}