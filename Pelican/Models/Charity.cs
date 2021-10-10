using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pelican.Models
{
    public class Charity
    {
        public int CharityID { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public int TotalDonations { get; set; }

        public void Donate(int donation)
        {
            TotalDonations = TotalDonations + donation;
        }
    }
}
