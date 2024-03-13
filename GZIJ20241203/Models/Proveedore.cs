using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GZIJ20241203.Models
{
    public partial class Proveedore
    {
        public Proveedore()
        {
            DireccionesProveedors = new List<DireccionesProveedor>();
        }

        [Key]
        public int IdProveedor { get; set; }

        [Required(ErrorMessage ="El campo Nombre es requerido")]
        public string Nombre { get; set; } = null!;

        [Display(Name = "Teléfono")]
        [Phone(ErrorMessage = "Digíte un número de teléfono valido")]
        public string? Telefono { get; set; }

        [EmailAddress(ErrorMessage = "Digíte un correo electrónico valido")]
        [Display(Name ="Correo Electronico")]
        public string? CorreoElectronico { get; set; }
        public string? Producto { get; set; }

        [Display(Name = "Fecha de registro")]
        public DateTime? FechaRegistro { get; set; }

        public virtual IList<DireccionesProveedor> DireccionesProveedors { get; set; }
    }
}
