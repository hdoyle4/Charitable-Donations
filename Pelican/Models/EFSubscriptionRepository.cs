using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pelican.Models
{
    public class EFSubscriptionRepository : ISubscriptionRepository
    {
        private ApplicationDbContext context;
        public EFSubscriptionRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IEnumerable<Subscription> Subscriptions => context.Subscriptions;
    }
}
