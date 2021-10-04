using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BettingSite.Models
{
    public class Match
    {
        [Key]
        public int Id { get; set; }
        public string HomeTeam { get; set; }
        public string AwayTeam { get; set; }
        public bool Updated { get; set; }
        public DateTime MatchTime { get; set; }
        public DateTime InsertedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

    }
}
