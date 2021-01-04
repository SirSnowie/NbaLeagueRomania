using NbaLeagueRomania.entities;
using NbaLeagueRomania.repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace NbaLeagueRomania.service
{
    class ActivePlayersService
    {
        private IRepository<Tuple<long, long>, ActivePlayer> repository;

        public ActivePlayersService(IRepository<Tuple<long, long>, ActivePlayer> repository)
        {
            this.repository = repository;
        }

        public ActivePlayer AddActivePlayer(ActivePlayer newActivePlayer)
        {
            newActivePlayer.ID = new Tuple<long, long>(newActivePlayer.idJucator, newActivePlayer.idMeci);
            return repository.Save(newActivePlayer);
        }

        public ActivePlayer DeleteActivePlayer(Tuple<long,long> id)
        {
            return repository.Delete(id);
        }

        public IEnumerable<ActivePlayer> GetAllActivePlayers()
        {
            return repository.GetAll();
        }

        public List<ActivePlayer> GetActivePlayersOfGame(long gameID)
        {
            List<ActivePlayer> players = new List<ActivePlayer>();
            foreach (var x in repository.GetAll())
                if (x.idMeci.Equals(gameID))
                    players.Add(x);
            return players;

        }


    }

   

}

