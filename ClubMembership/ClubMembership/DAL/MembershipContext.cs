using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ClubMembership.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ClubMembership.DAL
{
    public class MembershipContext : DbContext
    {
        public MembershipContext() : base("MembershipContext")
        {
        }

        public DbSet<Member> Members { get; set; }
        public DbSet<Campaign> Campaigns { get; set; }
        public DbSet<Edition> Editions { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}