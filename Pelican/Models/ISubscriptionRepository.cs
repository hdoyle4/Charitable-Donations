using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pelican.Models
{
    public interface ISubscriptionRepository
    {
        IEnumerable<Subscription> Subscriptions { get; }
    }
}
