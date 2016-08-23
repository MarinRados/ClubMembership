using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClubMembership.Models
{
    public class Campaign
    {
        public int CampaignId { get; set; }

        [Display(Name = "Title")]
        public string Title { get; set; }

        public int EditionId { get; set; }

        [Display(Name = "Level")]
        public int Level { get; set; }

        [Display(Name = "Edition")]
        public virtual Edition Edition { get; set; }

        public virtual ICollection<Member> Members { get; set; }
    }
}