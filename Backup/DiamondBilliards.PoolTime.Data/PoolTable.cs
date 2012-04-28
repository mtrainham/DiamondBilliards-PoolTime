/*********************************************************************
 * SixSence.PoolTime.BusinessLayer: PoolTable.cs
 * By: Mitch Trainham
 * Last Updated:
 * 
 * PoolTable class that represents a pool table from the PoolTimeDB
 * database.
 *********************************************************************/

using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace DiamondBilliards.PoolTime.Data
{
    // disable never used warnings for fields that are being used by LINQ
    #pragma warning disable 0169, 0649

    [Table(Name="Tables")] // binds this class to Tables table in DB
    public class PoolTable
    {
        private TableStatus status; // current status of pool table

        private EntitySet<Player> players; // collection of players on this table

        public event EventHandler StatusChangedHandler;

        // binds property to TableNum column in table
        [Column(IsPrimaryKey = true)]
        public int TableNum { get; private set; } // table number (primary key)

        // binds property to Name column in table
        [Column]
        public string Name { get; private set; } // table name

        // binds property to Status column in table
        [Column]
        public TableStatus Status {
            get { return status; }
            set
            {
                status = (TableStatus)value; // converts integer from database to a TableStatus
                OnStatusChanged();
            } // end set
        } // end property TableStatus

        // uses an association between the primary key of this table
        // and the foreign key of the Players table to reference
        // all players that belong to this table
        [Association(Name = "FK_Players_Tables",
            Storage = "players", OtherKey = "TableNum", ThisKey = "TableNum")]
        public ICollection<Player> Players
        {
            get { return players; }
            set { players.Assign(value); }
        } // end property Players

        // constructor
        public PoolTable()
        {
            // initialize players collection with delegates to be called
            // when a player is added or removed from the collection
            players = new EntitySet<Player>(OnPlayerAdded, OnPlayerRemoved);
        } // end constructor

        // when a player is added to this table set the player's
        // PoolTable property to this
        private void OnPlayerAdded(Player addedPlayer)
        {
            if (this.Status == TableStatus.Inactive)
            {
                this.Status = TableStatus.Active;
            }

            addedPlayer.PoolTable = this;
            AddPlayerTimestamps();
        } // end method OnPlayerAdded

        // when a player is removed from this table set the player's
        // PoolTable property to null
        private void OnPlayerRemoved(Player removedPlayer)
        {
            if (this.Players.Count < 1)
            {
                this.Status = TableStatus.Inactive;
            }

            removedPlayer.PoolTable = null;
            AddPlayerTimestamps();
        } // end method OnPlayerRemoved

        // add new time and number of players to each player
        private void AddPlayerTimestamps()
        {
            // code to update history of all players on table
        } // end method UpdatePlayerHistory()

        public void OnStatusChanged()
        {
            if (StatusChangedHandler != null)
                StatusChangedHandler(this, EventArgs.Empty);
        }
    } // end class PoolTable
} // end namespace SixSence.PoolTime.BusinessLayer
