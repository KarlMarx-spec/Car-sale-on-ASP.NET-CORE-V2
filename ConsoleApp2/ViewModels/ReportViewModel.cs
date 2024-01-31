﻿using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.ViewModels
{
    public class ReportViewModel
    {
        public string CurrentMonth = DateTime.Now.ToShortDateString();
        public IEnumerable<SellModel> SellModels { get; set; }
    }
}
