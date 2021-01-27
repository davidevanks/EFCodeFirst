using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    /// <summary>
    /// Almacenará la categoria de los trabajos
    /// </summary>
    public class CategoriasTrabajos
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaModificacion { get; set; }
        public bool Estado { get; set; }

        public ICollection<Trabajos> Trabajos { get; set; }
    }
}
