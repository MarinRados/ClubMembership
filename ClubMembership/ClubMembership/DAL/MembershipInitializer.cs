using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ClubMembership.Models;

namespace ClubMembership.DAL
{
    public class MembershipInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<MembershipContext>
    {
        protected override void Seed(MembershipContext context)
        {
            var Members = new List<Member>
            {
                new
                Member{FirstName="Vlado",LastName="Kopić",MembershipDate=DateTime.Parse("2015-09-01"),MemberType=MemberType.DM},
                new
                Member{FirstName="Marin",LastName="Radoš",MembershipDate=DateTime.Parse("2012-09-01"),MemberType=MemberType.DM},
                new
                Member{FirstName="Denis",LastName="Milošević",MembershipDate=DateTime.Parse("2013-09-01"),MemberType=MemberType.PC},
                new
                Member{FirstName="Michael",LastName="Tilhof",MembershipDate=DateTime.Parse("2012-09-01"),MemberType=MemberType.PC},
                new
                Member{FirstName="Maja",LastName="Gregić",MembershipDate=DateTime.Parse("2012-09-01"),MemberType=MemberType.PC},
                new
                Member{FirstName="Ana",LastName="Gregić",MembershipDate=DateTime.Parse("2011-09-01"),MemberType=MemberType.PC}
                };
                Members.ForEach(s => context.Members.Add(s));
                context.SaveChanges();
            var Editions = new List<Edition>
                {
                new Edition{EditionId=1,Title="1st Edition",Description=""},
                new Edition{EditionId=2,Title="2nd Edition",Description=""},
                new Edition{EditionId=3,Title="3rd Edition",Description=""},
                new Edition{EditionId=4,Title="3.5 Edition",Description=""},
                new Edition{EditionId=5,Title="4th Edition",Description=""},
                new Edition{EditionId=6,Title="5th Edition",Description=""},
                };
                Editions.ForEach(s => context.Editions.Add(s));
                context.SaveChanges();
            var Campaigns = new List<Campaign>
                {
                new Campaign{Title="Out of the Abyss", MemberId=1,EditionId=4,Level=1},
                new Campaign{Title="Campaign 2",MemberId=1,EditionId=5,Level=2},
                new Campaign{Title="Out of the Abyss",MemberId=2,EditionId=3,Level=10},
                new Campaign{Title="IDK",MemberId=2,EditionId=1,Level=1},
                new Campaign{Title="Stradh",MemberId=3,EditionId=4,Level=1},
                new Campaign{Title="Out of the Abyss",MemberId=4,EditionId=5,Level=11},
                new Campaign{Title="LMOP",MemberId=4,EditionId=5,Level=1},
                new Campaign{Title="Out of the Abyss",MemberId=5,EditionId=2,Level=5},
                new Campaign{Title="Out of the Abyss",MemberId=6,EditionId=5,Level=1},
                new Campaign{Title="LMOP",MemberId=6,EditionId=3,Level=1},
                };
                Campaigns.ForEach(s => context.Campaigns.Add(s));
                context.SaveChanges();
        }
    }
}