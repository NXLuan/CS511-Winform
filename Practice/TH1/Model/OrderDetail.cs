using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.TH1.Model
{
    [Serializable]
    public class OrderDetail
    {
        public List<ServiceModel> Services { get; set; }
        public decimal TotolPrice { get; set; } 
    }
}
