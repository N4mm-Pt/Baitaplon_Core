using Baitaplon_Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Baitaplon_Core.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_Movie>().HasKey(am => new {
                am.ActorId,
                am.MoviesId
            });
            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Movies).WithMany(am => am.Actor_Movies).HasForeignKey(m => m.MoviesId);
            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Actor).WithMany(am => am.Actor_Movies).HasForeignKey(m => m.ActorId);

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Actor> Actors { set; get; }
        public DbSet<Movies> Movies { set; get; }
        public DbSet<Actor_Movie> Actors_Movies { set; get; }
        public DbSet<Cinema> Cinemas { set; get; }
        public DbSet<Producer> Producers { set; get; }
    }
}
