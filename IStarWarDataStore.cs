using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StarWar.Models;

namespace StarWar.Services
{
     interface IStarWarDataStore<T>
    {
       
            Task<IEnumerable<People>> GetPeopleAsync(int count);
    }
}

