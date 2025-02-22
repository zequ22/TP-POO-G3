﻿using System;
using System.Data.Entity;
using System.Linq;

namespace CONTEXTO
{
    public class PIZZERIA : DbContext
    {
        //Genero la creacion del contexto a partir del patron Singleton
        private static PIZZERIA instancia;
        public static PIZZERIA obtener_instancia()
        {
            if (instancia == null)
            {
                instancia = new PIZZERIA();
            }
            return instancia;
        }

        // El contexto se ha configurado para usar una cadena de conexión 'PIZZERIA' del archivo 
        // de configuración de la aplicación (App.config o Web.config). De forma predeterminada, 
        // esta cadena de conexión tiene como destino la base de datos 'CONTEXTO.PIZZERIA' de la instancia LocalDb. 
        // 
        // Si desea tener como destino una base de datos y/o un proveedor de base de datos diferente, 
        // modifique la cadena de conexión 'PIZZERIA'  en el archivo de configuración de la aplicación.
        public PIZZERIA()
            : base("name=PIZZERIA")
        {
        }

        // Agregue un DbSet para cada tipo de entidad que desee incluir en el modelo. Para obtener más información 
        // sobre cómo configurar y usar un modelo Code First, vea http://go.microsoft.com/fwlink/?LinkId=390109.
        
        public virtual DbSet<MODELO.CLIENTE> CLIENTES { get; set; }

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MODELO.CLIENTE>()
                .HasKey(c => c.CODIGO);
        }

    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}