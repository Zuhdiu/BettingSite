
using BettingSite.Interfaces;
using BettingSite.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BettingSite.Repositories
{
    public class MatchRepository : IMatchRepository
    {
        private readonly BetContext _context;

        public MatchRepository(BetContext context)
        {
            _context = context;
        }
        public async Task<Match> Create(Match match)
        {
            match.InsertedAt = DateTime.Now;
            _context.Matchs.Add(match);
          await _context.SaveChangesAsync();
            return match;
            
        }

        public async Task Delete(int id)
        {
            var matchsToDelete = await _context.Matchs.FindAsync(id);
            _context.Matchs.Remove(matchsToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Match>> Get()
        {
            return await _context.Matchs.ToListAsync();
        }

        public async Task<Match> Get(int id)
        {
            return await _context.Matchs.FindAsync(id);
        }

        public async Task Update(Match match)
        {
            match.UpdatedAt = DateTime.Now;
            match.Updated = true;
            _context.Matchs.Update(match);
            await _context.SaveChangesAsync();
        }

      
    }
}
