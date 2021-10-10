using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pelican.Models
{
    public interface ICharityRepository
    {
        IEnumerable<Charity> Charities { get; }
    }
}
