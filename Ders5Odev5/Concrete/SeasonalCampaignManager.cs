using Ders5Odev5.Abstract;
using Ders5Odev5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ders5Odev5.Concrete
{
    public class SeasonalCampaignManager:BaseCampaignManager
    {
        public override void Add(Campaign campaign)
        {
            Console.WriteLine("\n \nSezon Kampanyası: \n");
            base.Add(campaign);
        }
        public override void Delete(Campaign campaign)
        {
            Console.WriteLine("\n \nSezon Kampanyası: \n");
            base.Delete(campaign);
        }
        public override void Update(Campaign campaign)
        {
            Console.WriteLine("\n \nSezon Kampanyası: \n");
            base.Update(campaign);
        }
    }
}
