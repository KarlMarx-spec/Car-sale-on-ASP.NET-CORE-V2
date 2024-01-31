using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.ViewModels
{
    public class CatalogViewModel
    {
        public string user_login { get; set; }
        public IEnumerable<CatalogModel> catalogModels { get; set; }

    }
}
