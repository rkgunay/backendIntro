using System;
using System.Collections.Generic;
using System.Text;

namespace Ders5Odev5.Entities
{
    public class Campaign
    {
        public int Id { get; set; }
        public double DiscountPercentage { get; set; }
        public string CampaignName { get; set; }
        public string CampaignDefinition { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
