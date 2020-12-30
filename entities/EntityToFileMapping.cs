using System;
using System.Collections.Generic;
using System.Text;

namespace NbaLeagueRomania.entities
{
    class EntityToFileMapping
    {
        public static Team CreateTeam(string line)
        {
            string[] fields = line.Split('|');
            Team team = new Team(fields[1]);
            team.ID = long.Parse(fields[0]);
            return team;
        }

        public static ActivePlayer CreateActivePlayer(string line)
        {
            string[] fields = line.Split('|');
            ActivePlayer activePlayer = new ActivePlayer(long.Parse(fields[0]), long.Parse(fields[1]), int.Parse(fields[2]), (Tip)Enum.Parse(typeof(Tip), fields[3]));
            activePlayer.ID = new Tuple<long, long>(activePlayer.idJucator, activePlayer.idMeci);
            return activePlayer;
        }

    }
}
