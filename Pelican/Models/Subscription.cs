using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pelican.Models
{
    public class Subscription
    {
        public int SubscriptionID { get; set; }

        public String SubscriptionType { get; set; }
        public Boolean SubscriptionActive { get; set; }

        public Charity PreferedCharity { get; set; }
    }
}
