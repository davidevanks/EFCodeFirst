using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    /// <summary>
    /// Modelo que almacenará los tipo de contrato
    /// </summary>
    public class TipoContrato
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaModificacion { get; set; }
        public bool Estado { get; set; }

        public ICollection<Trabajos> Trabajos { get; set; }
    }
}
