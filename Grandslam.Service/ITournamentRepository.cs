using Grandslam.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Grandslam.Service
{
    public interface ITournamentRepository
    {
        List<Tournament> GetTournaments();
    }
}
