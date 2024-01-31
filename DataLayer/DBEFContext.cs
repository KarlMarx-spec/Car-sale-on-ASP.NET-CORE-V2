using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    class DBEFContext : DbContext
    {
        public DBEFContext(DbContextOptions<DBEFContext> options) : base(options) { }
    }
}
