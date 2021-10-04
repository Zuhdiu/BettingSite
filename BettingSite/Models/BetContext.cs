using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BettingSite.Models
{
    public class BetContext:DbContext
    {
        public BetContext(DbContextOptions<BetContext> options) : base(options)
        {

        }

        public virtual DbSet<Bets> Bets { get; set; }
        public virtual DbSet<Match> Matchs { get; set; }
    }
}
