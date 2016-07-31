using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClubMembership.Models
{
    public enum MemberType
    {
        DM, PC
    }

    public class Member
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Points { get; set; }
        public DateTime MembershipDate { get; set; }
        public MemberType MemberType { get; set; }

        public virtual ICollection<Campaign> Campaigns { get; set; }
    }
}