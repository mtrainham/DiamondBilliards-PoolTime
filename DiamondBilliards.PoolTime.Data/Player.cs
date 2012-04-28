/*********************************************************************
 * SixSence.PoolTime.BusinessLayer: Player.cs
 * By: Mitch Trainham
 * Last Updated:
 * 
 * Player class that represents a player from the PoolTimeDB database.
 *********************************************************************/

using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace DiamondBilliards.PoolTime.Data
{
    // disable never used warnings for fields that are being used by LINQ
    #pragma warning disable 0169, 0649

    [Table(Name = "Players")] // binds this class to Players table in DB
    public class Player
    {
        // private field that references the player's pool table object
        private EntityRef<PoolTable> poolTable = new EntityRef<PoolTable>();

        private EntitySet<Timestamp> timestamps; // collection of timestamps belonging
                                                 // to this player

        // binds property to Id column in Players table
        [Column(Name = "PlayerID", IsPrimaryKey = true, IsDbGenerated = true)]
        public int ID { get; private set; } // unique id of player (primary key)

        // binds property to TableNum column in Players table
        [Column]
        public int TableNum { get; set; } // number of table the player is on

        // binds property to Name column in Players table
        [Column]
        public string Name { get; set; } // player's name

        // binds property to StartTime column in Players table
        [Column]
        public DateTime StartTime { get; set; } // time the player started playing

        // binds property to Status column in Players table
        [Column]
        public int Status { get; set; } // privilege status of player

        // uses an association between the Players table's foreign key TableNum
        // and the Tables table's primary key TableNum to reference the corresponding
        // PoolTable object
        [Association(Name = "FK_Players_Tables",
            IsForeignKey = true, Storage = "poolTable", ThisKey = "TableNum")]
        public PoolTable PoolTable
        {
            get { return poolTable.Entity; }

            set 
            {
                PoolTable oldTable = poolTable.Entity; // store current table
                PoolTable newTable = value; // store new table

                // make sure both tables aren't the same
                if (oldTable != newTable)
                {
                    // clear the current poolTable before calling other objects
                    poolTable.Entity = null;

                    if (oldTable != null) // make sure oldTable exists
                    {
                        oldTable.Players.Remove(this); // remove this player from current table
                    } // end if

                    // set current pool table to new table before calling other objects
                    poolTable.Entity = newTable;

                    if (newTable != null) // make sure newTable exists
                    {
                        newTable.Players.Add(this); // add this player to new table
                    } // end if
                } // end if
            } // end set
        } // end property PoolTable

        // uses an association between the primary key of this table
        // and the foreign key of the Timestamps table to reference
        // all timestamps that belong to this player
        [Association(Name = "FK_Timestamps_Players",
            Storage = "timestamps", OtherKey = "PlayerID", ThisKey = "ID")]
        public ICollection<Timestamp> Timestamps
        {
            get { return timestamps; }
            set { timestamps.Assign(value); }
        } // end property Timestamps

        // overloaded 3-parameter constructor
        public Player(int tableNum, string name, DateTime startTime)
        {
            this.TableNum = tableNum;
            this.Name = name;
            this.StartTime = startTime;
            this.Status = 1;

            timestamps = new EntitySet<Timestamp>(OnTimestampAdded, OnTimestampRemoved);
        } // end constructor

        // overloaded 3-parameter constructor
        public Player(string name, DateTime startTime)
        {
            this.Name = name;
            this.StartTime = startTime;
            this.Status = 1;

            timestamps = new EntitySet<Timestamp>(OnTimestampAdded, OnTimestampRemoved);
        } // end constructor

        // default parameterless constructor
        public Player() { }

        private void OnTimestampAdded(Timestamp addedTimestamp)
        {

        }

        private void OnTimestampRemoved(Timestamp removedTimestamp)
        {

        }
    } // end class Player
} // end namespace SixSence.PoolTime.BusinessLayer
