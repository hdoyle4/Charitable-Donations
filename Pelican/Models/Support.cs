using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pelican.Models
{
    public class Support
    {
        public int SupportID { get; set; }
        public int ErrorCode { get; set; }

        public string CustomerQuestion { get; set; }
        public string CustomerEmail { get; set; }
        
    }
}
