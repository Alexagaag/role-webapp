using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RoleWebApp.Models
{
    [Table("RWA.TipoPermiso")]
    public class TipoPermiso
    {
        [Key]
        public int Id { get; set; }
        [StringLength(150), Required]
        public string Descripcion { get; set; }
    }
}
