using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Parcial2DB : DbContext
    {
        public Parcial2DB() : base("name=ConStr")
        {

        }
        public virtual DbSet<Clientes> clientes { get; set; }
        public virtual DbSet<TiposTelefonos> TipoTelefono { get; set; }
        public virtual DbSet<ClientesTelefonos> CLientT{ get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TiposTelefonos>()
                .HasMany<Clientes>(c => c.Client)
                .WithMany(d => d.Tipo)
                .Map(FE =>
                {
                    FE.MapLeftKey("TipoId");
                    FE.MapRightKey("ClienteId");
                    FE.ToTable("ClientesTelefonos");
                });
        }
        
    }
}

