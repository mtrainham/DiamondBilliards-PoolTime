using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DiamondBilliards.PoolTime.Data;

namespace DiamondBilliards.PoolTime.Business
{
    public static class PlayerNameFunctions
    {
        public static bool CheckForDuplicates( string name, List<string> playerNames )
        {
            int count = 0;

            foreach ( string playerName in playerNames )
            {
                if ( playerName == name )
                {
                    if ( ++count >= 1 )
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static string GetDefaultName( int playerNumber, List<string> playerNames )
        {
            bool gotName = false;
            string playerName = "Player " + playerNumber;

            while ( !gotName )
            {
                if ( CheckForDuplicates( playerName, playerNames ) )
                {
                    playerName = "Player " + ++playerNumber;
                } else
                {
                    gotName = true;
                }
            }

            return playerName;
        }

        public static string GetName( string name, List<string> playerNames )
        {
            bool gotName = false;
            int currentDuplicate = 1;
            string newPlayerName = name;

            if ( name == null || name == string.Empty || name == "" )
            {
                newPlayerName = GetDefaultName( playerNames.Count, playerNames );
            } else
            {
                while ( !gotName )
                {
                    if ( CheckForDuplicates( newPlayerName, playerNames ) )
                    {
                        newPlayerName = name + "(" + ++currentDuplicate + ")";
                    } else
                    {
                        gotName = true;
                    }
                }
            }

            return newPlayerName;
        }

        public static List<string> GetPlayerNames( PoolTable table )
        {
            List<string> playerNames = new List<string>();

            foreach (Player player in table.Players )
            {
                playerNames.Add( player.Name );
            }

            return playerNames;
        }
    }
}
