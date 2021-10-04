using BettingSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BettingSite.Interfaces
{
    public interface IMatchRepository
    {    

        Task<IEnumerable<Match>> Get();
        Task<Match> Get(int id);
        Task<Match> Create(Match match);
        Task Update(Match match);
        Task Delete(int id);
    }
}
