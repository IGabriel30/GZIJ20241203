using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GZIJ20241203.Models
{
    public partial class DireccionesProveedor
    {
        [Key]
        public int IdDireccion { get; set; }
        public int ProveedorId { get; set; }

        [Required(ErrorMessage ="El campo Dirección es requerido")]
        [Display(Name = "Dirección")]
        public string Direccion { get; set; } = null!;
        [Required(ErrorMessage = "El campo Ciudad es requerido")]
        public string? Ciudad { get; set; }

        [Display(Name = "País")]
        public string? Pais { get; set; }

        public virtual Proveedore Proveedor { get; set; } = null!;
    }
}
