using BettingSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BettingSite.Repositories
{
    public interface IBetsRepository
    {
        Task<IEnumerable<Bets>> Get();
        Task<Bets> Get(int id);
        Task<Bets> Create(Bets bets);
        Task Update(Bets bets);
        Task Delete(int id);
    }
}
