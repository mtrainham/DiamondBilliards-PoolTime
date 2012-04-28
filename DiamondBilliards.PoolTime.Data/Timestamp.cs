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

    [Table(Name = "Timestamps")] // binds this class to Tables table in DB
    public class Timestamp
    {
        private EntityRef<Player> player = new EntityRef<Player>();

        // binds property to Timestamp PK column in table
        [Column(Name = "TimestampID", IsPrimaryKey = true, IsDbGenerated = true)]
        public int ID { get; private set; } // TimestampID (primary key)

        // binds property to PlayerID FK column in table
        [Column]
        public int PlayerID { get; private set; } // table name

        // binds property to TableNum FK column in table
        [Column]
        public int TableNum { get; private set; } // table number

        // binds property to NumPlayers column in table
        [Column]
        public int NumPlayers { get; private set; } // number of players on table

        // binds property to StartTime column in table
        [Column]
        public DateTime StartTime { get; set; } // player start time

        // uses an association between the Players table's foreign key TableNum
        // and the Tables table's primary key TableNum to reference the corresponding
        // PoolTable object
        [Association(Name = "FK_Timestamps_Players",
            IsForeignKey = true, Storage = "player", ThisKey = "PlayerID")]
        public Player Player
        {
            get { return player.Entity; }

            private set 
            {
                Player newPlayer = value;
                player.Entity = newPlayer;

                if (newPlayer != null)
                {
                    newPlayer.Timestamps.Add(this);
                }
            }
        }

        // overloaded constructor
        public Timestamp(int playerID, int tableNum, int numPlayers, DateTime startTime)
        {
            this.PlayerID = playerID;
            this.TableNum = tableNum;
            this.NumPlayers = numPlayers;
            this.StartTime = startTime;
        } // end constructor

        // overloaded constructor
        public Timestamp(int tableNum, DateTime startTime)
        {
            this.TableNum = tableNum;
            this.StartTime = startTime;
        } // end constructor

        // default parameterless constructor
        public Timestamp() { }
    }
}