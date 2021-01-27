using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    /// <summary>
    /// Almacenará la información de trabajo
    /// </summary>
    [Table("TablaTrabajos",Schema = "MiBaseDeDatos")]
    public class Trabajos
    {
        [Key]
        public int Id { get; set; }
        [Column("TituloTrabajo")]
        [Required]
        [MaxLength(50)]
        public string Titulo { get; set; }
        [Required]
        public string Ubicacion { get; set; }
        //[Index("INDEX_SALARIO",IsClustered = true,IsUnique = false)]
        [Required]
        public double Salario { get; set; }
        [Required]
        public string Descripcion { get; set; }
        
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaModificacion { get; set; }
       
        public bool Estado { get; set; }
        [ForeignKey("TipoContrato")]
        public int TipoContratoId { get; set; }

        public TipoContrato TipoContrato { get; set; }
        [ForeignKey("CategoriasTrabajos")]
        public int CategoriaTrabajoId { get; set; }

        public CategoriasTrabajos CategoriasTrabajos { get; set; }
    }
}
