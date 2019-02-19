using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyWebStore.DomainEntities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebStore.DALNew.Context
{
    public class MyWebStoreContext : IdentityDbContext
    {
        public MyWebStoreContext(DbContextOptions<MyWebStoreContext> options) : base(options) { }

        public DbSet<Section> Sections { get; set; }

        public DbSet<Brand> Brands { get; set; }

        public DbSet<Product> Products { get; set; }
    }
}
