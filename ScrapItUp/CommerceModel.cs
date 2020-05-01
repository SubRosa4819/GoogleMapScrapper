using System;
using System.Collections.Generic;
using System.Text;

namespace ScrapItUp
{
    class listCommerceModel
    {
        public QueryModel query { get; set; } = new QueryModel();
        public List<CommerceModel> list { get; set; } = new List<CommerceModel>();
    }
    class CommerceModel
    {
        public string nom { get; set; }
        public string adresse { get; set; }
        public string numero { get; set; }
    }
}
