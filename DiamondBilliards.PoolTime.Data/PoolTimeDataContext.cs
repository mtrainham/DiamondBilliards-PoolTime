/*********************************************************************
 * SixSence.PoolTime.BusinessLayer: PoolTimeDB.cs
 * By: Mitch Trainham
 * Last Updated:
 * 
 * PoolTimeDB class used as the DataContext object that contains all
 * of tables and data from the PoolTimeDB database.
 *********************************************************************/

using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace DiamondBilliards.PoolTime.Data
{
    // disable never used warnings for fields that are being used by LINQ
    #pragma warning disable 0169

    [Database] // binds this class to PoolTimeDB database
    public class PoolTimeDataContext : DataContext
    {
        public Table<PoolTable> PoolTables; // collection of pool tables in DB
        public Table<Player> Players; // collection of players in DB
        public Table<Timestamp> Timestamps; // collection of timestamps in DB

        // constructor that calls base class constructor
        public PoolTimeDataContext()
            : base("Data Source=|DataDirectory|PoolTime.sdf") { }

        public PoolTimeDataContext(IDbConnection connection) : base(connection) { }

        // validate table objects just before SubmitChanges is called
        public void Validate()
        {
            // loop through all the players
            foreach (var player in Players)
            {
                // if the player is not on a table, delete the player
                // when SubmitChanges is called
                if (player.PoolTable == null)
                {
                    Players.DeleteOnSubmit(player);
                } // end if
            } // end foreach
        } // end method Validate
    } // end class PoolTimeDB
} // end namespace SixSence.PoolTime.BusinessLayer
