using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Gherman_Daria_Lab2.Models;

namespace Gherman_Daria_Lab2.Data
{
    public class Gherman_Daria_Lab2Context : DbContext
    {
        public Gherman_Daria_Lab2Context (DbContextOptions<Gherman_Daria_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Gherman_Daria_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Gherman_Daria_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Gherman_Daria_Lab2.Models.Author> Authors { get; set; } = default!;

    }
}
