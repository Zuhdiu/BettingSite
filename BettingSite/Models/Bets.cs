using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BettingSite.Models
{
    public class Bets
    {
        [Key]
        public int ID { get; set; }
        public int MatchID { get; set; }
        public virtual Match match { get; set; }
        public double Amount { get; set; }
        public string BetType { get; set; }
        public double Odds { get; set; }
        public bool Updated { get; set; }       
        public DateTime InsertedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
