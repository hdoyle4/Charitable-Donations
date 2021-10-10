using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pelican.Models
{
    public class Donation
    {
        public int CharityID { get; set; } //May need a method here that interacts with charity.cs instead
        public int DontationID { get; set; }
        public int DonationAmount { get; set; }
    }
}
