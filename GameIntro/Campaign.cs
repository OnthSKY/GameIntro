using System.Collections.Generic;
using System.Text;

namespace GameIntro
{
    class Campaign
    {
        public int Id { get; set; }
        public string Explanation { get; set; }
        double campainCount;
        public double CampaingCount
        {
            get { return campainCount; }
            set {
                if ((value > 0) && (value < 100))
                    campainCount = value;
                else
                    campainCount = 0;
                }
            
        }


    }
}
