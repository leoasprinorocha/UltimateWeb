using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UltimateWeb.Models;

namespace UltimateWeb.Data
{
    public class UltimateWebContext : DbContext
    {
        public UltimateWebContext (DbContextOptions<UltimateWebContext> options)
            : base(options)
        {
        }

        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<Treinador> Treinador { get; set; }
    }
}
