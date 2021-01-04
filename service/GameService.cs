using NbaLeagueRomania.entities;
using NbaLeagueRomania.repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace NbaLeagueRomania.service
{
    class GameService
    {
        private IRepository<long, Game> repository;

        public GameService(IRepository<long, Game> repository)
        {
            this.repository = repository;
        }

        public Game AddGame(Game newGame)
        {
            newGame.ID = GetNewId();
            return repository.Save(newGame);
        }

        private long GetNewId()
        {
            long newID = -1;
            foreach (var x in repository.GetAll())
            {
                newID = x.ID;
            }
            return ++newID;
        }

        public Game DeleteGame(long id)
        {
            return repository.Delete(id);
        }

        public IEnumerable<Game> GetAll()
        {
            return repository.GetAll();
        }

        public Game GetOne(long id)
        {
            return repository.GetOne(id);
        }

        public List<Game> GetGamesBetween(DateTime start, DateTime end)
        {
            List<Game> games = new List<Game>();
            foreach (Game g in repository.GetAll())
                if (g.DateTime.CompareTo(start) >= 0 && g.DateTime.CompareTo(end) <= 0)
                    games.Add(g);
            return games;

        }
    }
}
