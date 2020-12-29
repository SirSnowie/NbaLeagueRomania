using NbaLeagueRomania.entities;
using NbaLeagueRomania.repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace NbaLeagueRomania.service
{
    class TeamService
    {
        private IRepository<long,Team> repository;

        public TeamService(IRepository<long, Team> repository)
        {
            this.repository = repository;
        }

        public Team AddTeam(Team newTeam)
        {
            newTeam.ID = GetNewId();
            return repository.Save(newTeam);
        }

        private long GetNewId()
        {
            long newID = -1;
            foreach(var x in repository.GetAll())
            {
                newID = x.ID;
            }
            return ++newID;
        }

        public Team DeleteTeam(long id)
        {
            return repository.Delete(id);
        }

        public IEnumerable<Team> GetAllTeams()
        {
            return repository.GetAll();
        }
       
        public Team GetOne(long id)
        {
           return repository.GetOne(id);
        }
    }
}
