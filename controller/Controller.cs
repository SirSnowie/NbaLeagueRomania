using NbaLeagueRomania.service;
using System;
using System.Collections.Generic;
using System.Text;

namespace NbaLeagueRomania.controller
{
    class Controller
    {
        ActivePlayersService activePlayerService;
        TeamService teamService;
        PlayerService playerService;
        GameService gameService;

        public Controller(ActivePlayersService activePlayerService, TeamService teamService, PlayerService playerService, GameService gameService)
        {
            this.activePlayerService = activePlayerService;
            this.teamService = teamService;
            this.playerService = playerService;
            this.gameService = gameService;
        }


    }
}
