using BettingSite.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BettingSite.Repositories
{
    public class BetsRepository : IBetsRepository
    {
        private readonly BetContext _context;

        public BetsRepository(BetContext context)
        {
            _context = context;
        }
        public async Task<Bets> Create(Bets bets)
        {
            _context.Bets.Add(bets);
            await _context.SaveChangesAsync();

            return bets;
        }

        public async Task Delete(int id)
        {
            var betsToDelete = await _context.Bets.FindAsync(id);
            _context.Bets.Remove(betsToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Bets>> Get()
        {
            return await _context.Bets.ToListAsync();
        }

        public async Task<Bets> Get(int id)
        {
            return await _context.Bets.FindAsync(id);
        }

        public async Task Update(Bets bets)
        {
            bets.UpdatedAt = DateTime.Now;
            bets.Updated = true;
            _context.Entry(bets).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
