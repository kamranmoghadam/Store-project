﻿using InventoryManagement.Domain.InventoryAgg;
using Microsoft.EntityFrameworkCore;
using System;
using InventoryMangement.Infrastructure.EFCore.Mappings;

namespace InventoryMangement.Infrastructure.EFCore
{
    public class InventoryContext : DbContext
    {
        public DbSet<Inventory> Inventory { get; set; }
        public InventoryContext(DbContextOptions<InventoryContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var assembly = typeof(InventoryMapping).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
