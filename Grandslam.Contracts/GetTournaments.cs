using ServiceStack;
using System;
using System.Collections.Generic;
using System.Text;

namespace Grandslam.Contracts
{
    [Route("/titles", "GET")]
    public class GetTournaments: IGet, IReturn<List<Tournament>>
    {

    }
}
