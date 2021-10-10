using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pelican.Models
{
    public class EFSupportRepository : ISupportRepository
    {
        private ApplicationDbContext context;
        public EFSupportRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IEnumerable<Support> Supports => context.Support;
    }
}
