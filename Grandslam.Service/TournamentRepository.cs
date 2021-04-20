using System;
using System.Collections.Generic;
using System.Text;
using Grandslam.Contracts;

namespace Grandslam.Service
{
    public class TournamentRepository : ITournamentRepository
    {
        public List<Tournament> GetTournaments()
        {
            return new List<Tournament>()
            {
                new Tournament() { Name="Australian Open1", Stadium ="Rod Laver Arena", Country ="Australia" },
                new Tournament() { Name = "French open", Stadium ="Stade Roland Garros", Country ="France"},
                new Tournament() { Name ="Wimbledon", Stadium ="Wimbledon", Country = "United Kingdom" },
                new Tournament() { Name="US Open", Stadium="BJK National Tennis Center", Country="USA"},
            };
        }
    }
}
