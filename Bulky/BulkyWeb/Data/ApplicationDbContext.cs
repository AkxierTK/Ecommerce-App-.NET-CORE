﻿using BulkyWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyWeb.Data
{
    /*
     DbContext es el objeto con la configuración para conectar el proyecto con la base de datos
     */
    public class ApplicationDbContext : DbContext
    {
        /*
         Options en este caso lo que hace es que la configuración que se establezca en DbContextOptions pasa a la clase base DbContext
         */
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            

        }

        /* Aqui debemos poner los modelos que queremos generar en la base de datos del contexto

          Primero debemos generar la migración en la consola de comandos de paquetes Nuget con el siguiente comando -- > add-migration nombreMigracion

          Una vez hecho esto se nos creará la carpeta Migrations con la migración.

          Por último debemos hacer que esa migración se aplique a la bd con el siguiente comando aplicando las migraciones -> update-database

         */
        public DbSet<Category> Categories { get; set; }

        /*
         Podemos sobrescribir el metodo OnModelCreating para cambiar los modelos, sus relaciones y añadir datos, para esto tambien se debe añadir una migración.

         En este ejemplo añadimos valores a la tabla categorias
         */
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Caja", DisplayOrder = 1 },
                new Category { CategoryId = 2, Name = "Carta", DisplayOrder = 2 },
                new Category { CategoryId = 3, Name = "Mazo", DisplayOrder = 3 }
                );
        }

    }
}
