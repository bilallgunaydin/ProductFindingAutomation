using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Price { get; set; }
        public string SiteName { get; set; }
        public DateTime ListDate { get; set; }
        public string Keyword { get; set; }
    }
}
