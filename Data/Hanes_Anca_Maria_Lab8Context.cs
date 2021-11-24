using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Hanes_Anca_Maria_Lab8.Models;

namespace Hanes_Anca_Maria_Lab8.Data
{
    public class Hanes_Anca_Maria_Lab8Context : DbContext
    {
        public Hanes_Anca_Maria_Lab8Context (DbContextOptions<Hanes_Anca_Maria_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Hanes_Anca_Maria_Lab8.Models.Book> Book { get; set; }

        public DbSet<Hanes_Anca_Maria_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Hanes_Anca_Maria_Lab8.Models.Category> Category { get; set; }
    }
}
