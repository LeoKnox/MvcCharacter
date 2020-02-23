using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcCharacter.Models;
using Microsoft.EntityFrameworkCore;
using MvcCharacter.Models;

namespace MvcCharacter.Data
{
    public class MvcCharacter223Context : DbContext
    {
        public MvcCharacter223Context (DbContextOptions<MvcCharacter223Context> options)
            : base(options)
        {
        }

        public DbSet<MvcCharacter.Models.Character> Character { get; set; }
        public DbSet<MvcCharacter.Models.Archon> Archons { get; set; }
        public DbSet<MvcCharacter.Models.Power> Powers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Character>().ToTable("Character");
            modelBuilder.Entity<Archon>().ToTable("Archon");
            modelBuilder.Entity<Power>().ToTable("Power");
        }
    }
}
