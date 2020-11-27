using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RoleWebApp.Models
{
    [Table("RWA.PERMISO")]
    public class Permiso
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50), Required]
        public string NombreEmpleado { get; set; }

        [StringLength(60), Required]
        public string ApellidosEmpleado { get; set; }

        [Required]
        public int TipoPermiso { get; set; }

        [ForeignKey("TipoPermiso")]
        public TipoPermiso FkTipoPermiso { get; set; }

        public DateTime FechaPermiso { get; set; } = DateTime.Now;
    }
}
