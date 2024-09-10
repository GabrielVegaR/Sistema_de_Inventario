using System;
using System.Collections.Generic;

namespace Sistema_de_Inventario.Models;

public partial class Proveedor
{
    public int ProveedorId { get; set; }

    public string Nombre { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string CodigoArea { get; set; } = null!;

    public string CodigoPais { get; set; } = null!;

    public string Telefono { get; set; } = null!;

    public DateTime? FechaCreacion { get; set; }

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
