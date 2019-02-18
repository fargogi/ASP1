using Microsoft.EntityFrameworkCore;
using MyWebStore.DomainEntities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebStore.DALNew.Context
{
    public class MyWebStoreContext : DbContext
    {
        public MyWebStoreContext(DbContextOptions<MyWebStoreContext> options) : base(options) { }

        DbSet<Section> Sections { get; set; }

        DbSet<Brand> Brands { get; set; }

        DbSet<Product> Products { get; set; }
    }
}
