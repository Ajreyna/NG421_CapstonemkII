using AutoMapper.Configuration;
using capstone.Models;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace capstone.Data
{

    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public IConfiguration Configuration { get; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Rocker> Rockers { get; set; }
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {

        }
        public ApplicationDbContext() : base(new DbContextOptionsBuilder<ApplicationDbContext>().UseSqlite("Data Source=app.db").Options, null)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Rocker>()
                .HasData(
                new Rocker { Id = 1, FirstName = "Iggy", LastName = "Pop", Instrument = "vocals", IsAlive = true },
                new Rocker { Id = 2, FirstName = "Ozzy", LastName = "Osbourne", Instrument = "vocals", IsAlive = true },
                new Rocker { Id = 3, FirstName = "Jimi", LastName = "Hendrix", Instrument = "Guitar/Vocals", IsAlive = false });
            base.OnModelCreating(builder);
        }


    }
}