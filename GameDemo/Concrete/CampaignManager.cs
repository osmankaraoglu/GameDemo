using GameDemo.Abstract;
using GameDemo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("The " + campaign.CampaignName +" campaign has started");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("The " + campaign.CampaignName + " has been deleted!");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("The " + campaign.CampaignName + " has updated");
        }
    }
}
