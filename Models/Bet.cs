using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace api_raw.Models
{
    public class Bet
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string ChallengerName { get; set; }
        public string OpponentName { get; set; }

        public int ChallengeId { get; set; }
        public int CategoryId { get; set; }
        public int UserId { get; set; }

        [JsonIgnore]
        public virtual Challenge Challenge { get; set; }
        public virtual Category Category { get; set; }
        public virtual User User { get; set; }
    }
}
