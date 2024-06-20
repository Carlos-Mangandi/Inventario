﻿using Microsoft.EntityFrameworkCore;

namespace Inventario.Backend.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Operacion> Operaciones { get; set; }
    }
}