using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class SellModel
    {
        public CarModel Car { get; set; }
        public string ManagerFIO { get; set; }
        public string ClientFIO { get; set; }
        public DateTime SellDate { get; set; }
    }
}
