using System;
using System.Collections.Generic;

namespace GZIJ20241203.Models
{
    public partial class Proveedore
    {
        public Proveedore()
        {
            DireccionesProveedors = new HashSet<DireccionesProveedor>();
        }

        public int IdProveedor { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Telefono { get; set; }
        public string? CorreoElectronico { get; set; }
        public string? Producto { get; set; }
        public DateTime? FechaRegistro { get; set; }

        public virtual ICollection<DireccionesProveedor> DireccionesProveedors { get; set; }
    }
}
