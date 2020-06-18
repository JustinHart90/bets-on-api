using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace api_raw.Models
{
    public class Challenge
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ChallengerName { get; set; }
        public string Description { get; set; }
        public string Terms { get; set; }
        public string Conditions { get; set; }
        public decimal Amount { get; set; }
        public bool IsAvailable { get; set; }

        public int CategoryId { get; set; }
        public int UserId { get; set; }

        public virtual List<Bet> Bets { get; set; }
        [JsonIgnore]
        public virtual Category Category { get; set; }
        public virtual User User { get; set; }
    }
}
