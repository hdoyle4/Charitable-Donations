using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pelican.Models
{
    public class FakeCharityRepository : ICharityRepository
    {
        public IEnumerable<Charity> Charities => new List<Charity>
        {
            new Charity { Name = "red cross", TotalDonations = 600 },
            new Charity { Name = "aids", TotalDonations =  179},
            new Charity { Name = "corona", TotalDonations = 75 },
        };
    }
}

