using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;


namespace DataAccess.DAL
{
    public class Contexto: DbContext
    {
        public Contexto(): base("MiBaseDeDatos")
        {
                Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Contexto>());

        }

        private DbSet<Trabajos> Trabajos { get; set; }
        private DbSet<TipoContrato> TiposContratos { get; set; }
        private DbSet<CategoriasTrabajos> CategoriasTrabajos { get; set; }
    }
}
