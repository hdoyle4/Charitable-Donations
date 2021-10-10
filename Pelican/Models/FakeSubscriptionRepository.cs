using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pelican.Models
{
    public class FakeSubscriptionRepository : ISubscriptionRepository
    {
        public IEnumerable<Subscription> Subscriptions => new List<Subscription>
        {
            new Subscription {  },
            
        };
    }
}

