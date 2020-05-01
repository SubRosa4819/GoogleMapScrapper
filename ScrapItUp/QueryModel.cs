using System;
using System.Collections.Generic;
using System.Text;

namespace ScrapItUp
{
    class QueryModel
    {
        public string localisation { get; set; }
        public string type { get; set; }
    
    }
    class QueryOptions
    {
        public bool fetchWebsiteDetails { get; set; } = false;
        public bool fetchOnlyNoWebsites { get; set; } = true;
    }
}
