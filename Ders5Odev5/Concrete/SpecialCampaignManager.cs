using Ders5Odev5.Abstract;
using Ders5Odev5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ders5Odev5.Concrete
{
    public class SpecialCampaignManager:BaseCampaignManager
    {
        public override void Add(Campaign campaign)
        {
            Console.WriteLine("Özel Kampanya: \n ");
            base.Add(campaign);
        }
        public override void Delete(Campaign campaign)
        {
            Console.WriteLine("Özel Kampanya: \n");
            base.Delete(campaign);
        }
        public override void Update(Campaign campaign)
        {
            Console.WriteLine("Özel Kampanya: \n");
            base.Update(campaign);
        }
    }
}
