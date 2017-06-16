using Grandslam.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Grandslam.Service
{
    public class TournamentService: ServiceStack.Service
    {
        public ITournamentRepository repo { get; set; }

        public List<Tournament> Get(GetTournaments request)
        {
            return repo.GetTournaments();
        }
    }
}
