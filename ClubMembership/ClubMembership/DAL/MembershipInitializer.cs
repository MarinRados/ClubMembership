using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ClubMembership.Models;

namespace ClubMembership.DAL
{
    public class MembershipInitializer : System.Data.Entity.DropCreateDatabaseAlways<MembershipContext> //TODO: change to model drop
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
                new Edition{EditionId=6,Title="5th Edition",Description=""}
                };
                Editions.ForEach(s => context.Editions.Add(s));
                context.SaveChanges();
            var Campaigns = new List<Campaign>
                {
                new Campaign{Title="Curse Of Stradh",EditionId=5,Level=12, Members = new List<Member>()},
                new Campaign{Title="Out of the Abyss",EditionId=5,Level=17, Members = new List<Member>()},
                new Campaign{Title="Lost Mine of Phandelver",EditionId=5,Level=1, Members = new List<Member>()}
                };
                Campaigns.ForEach(s => context.Campaigns.Add(s));
                context.SaveChanges();

                AddOrUpdateMember(context, "Curse Of Stradh", "Radoš");
                AddOrUpdateMember(context, "Curse Of Stradh", "Tilhof");
                AddOrUpdateMember(context, "Curse Of Stradh", "Milošević");
                AddOrUpdateMember(context, "Out of the Abyss", "Kopić");
                AddOrUpdateMember(context, "Out of the Abyss", "Milošević");
        }

        void AddOrUpdateMember(MembershipContext context, string campaignTitle, string memberName)
        {
            var cpm = context.Campaigns.SingleOrDefault(c => c.Title == campaignTitle);
            var mbm = cpm.Members.SingleOrDefault(m => m.LastName == memberName);
            if(mbm == null)
            {
                cpm.Members.Add(context.Members.Single(m => m.LastName == memberName));
            }
        }
    }
}