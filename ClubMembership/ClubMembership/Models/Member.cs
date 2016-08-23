using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Points")]
        public int Points { get; set; }

        [Display(Name = "Membership Date")]
        public DateTime MembershipDate { get; set; }

        [Display(Name = "Member type")]
        public MemberType MemberType { get; set; }

        [Display(Name = "Member")]
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        public virtual ICollection<Campaign> Campaigns { get; set; }
    }
}