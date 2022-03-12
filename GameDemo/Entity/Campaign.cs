using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Entity
{
    class Campaign
    {
        public int Id { get; set; }
        public string CampaignName { get; set; }
        public int DiscountPercent { get; set; }
        public DateTime CampaignTime { get; set; }

    }
}
