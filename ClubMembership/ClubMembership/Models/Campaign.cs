using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClubMembership.Models
{
    public class Campaign
    {
        public int CampaignId { get; set; }
        public string Title { get; set; }
        public int EditionId { get; set; }
        public int MemberId { get; set; }
        public int Level { get; set; }
        public string LevelRange { get; set; }

        public virtual Edition Edition { get; set; }
        public virtual ICollection<Member> Members { get; set; }
    }
}