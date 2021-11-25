using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ujlaki_Tamas_Lab8.Models;

namespace Ujlaki_Tamas_Lab8.Data
{
    public class Ujlaki_Tamas_Lab8Context : DbContext
    {
        public Ujlaki_Tamas_Lab8Context (DbContextOptions<Ujlaki_Tamas_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Ujlaki_Tamas_Lab8.Models.Book> Book { get; set; }

        public DbSet<Ujlaki_Tamas_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Ujlaki_Tamas_Lab8.Models.Category> Category { get; set; }
    }
}
