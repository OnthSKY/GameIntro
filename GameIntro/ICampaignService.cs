﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameIntro
{
    interface ICampaignService
    {
        void Add(Campaign campaign);
        void Update(Campaign campaign);
        void Delete(Campaign campaign);
        
    }
}
