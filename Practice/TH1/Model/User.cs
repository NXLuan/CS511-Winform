using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.TH1.Model
{
    [Serializable]
    public class User
    {
        public string HoTen { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public string Avatar { get; set; }
        public OrderDetail Cart { get; set; }
    }
}
