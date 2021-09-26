using Ders5Odev5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ders5Odev5.Abstract
{
    public abstract class BaseCampaignManager : ICampaignService
    {
        public virtual void Add(Campaign campaign)
        {
            Console.WriteLine("Yeni kampanya eklendi." +  "\n"+ campaign.CampaignName +"\n" + campaign.CampaignDefinition + "Kampanya İndirim Oranı: %"+campaign.DiscountPercentage);
        }

        public virtual void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya silindi." + "\n" + campaign.CampaignName + "\n" + campaign.CampaignDefinition + "Kampanya İndirim Oranı: %" + campaign.DiscountPercentage);
        }

        public virtual void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya güncellendi." + "\n" + campaign.CampaignName + "\n" + campaign.CampaignDefinition + "Kampanya İndirim Oranı: %" + campaign.DiscountPercentage);
        }
    }
}
