using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pelican.Models
{
    public class EFCharityRepository : ICharityRepository
    {
        private ApplicationDbContext context;
        public EFCharityRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IEnumerable<Charity> Charities => context.Charities;
    }
}
