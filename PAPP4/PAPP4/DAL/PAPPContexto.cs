using PAPP4.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace PAPP4.DAL
{
    public class PAPPContexto: DbContext
    {
        public PAPPContexto() : base("PAPPContexto")
        {
        }

        public DbSet<Contacto> Contacto { get; set; }
        public DbSet<Libro> Libro { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public System.Data.Entity.DbSet<PAPP4.Models.Login> Logins { get; set; }
    }
}