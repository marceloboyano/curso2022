using CLASE_29_EF_codeFirst.Modelo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CLASE_29_EF_codeFirst.Context
{
    internal class CodeFirstDbContext: DbContext
    {
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Deposito> Depositos { get; set; }
        public DbSet<Sucursal> Sucursales { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = DESKTOP-44QUODQ;Initial Catalog=EFCodeFirst; Trusted_Connection = True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}

//ver FluentAPI para configurar como se mapea el modelo de clase y sus propiedades