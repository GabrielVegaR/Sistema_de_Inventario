using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Sistema_de_Inventario.Models;

public partial class Producto
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ProductoId { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public decimal Precio { get; set; }

    public int Stock { get; set; }

    public int? IdCategoria { get; set; }

    public int? IdProveedor { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public virtual Categoria? IdCategoriaNavigation { get; set; }

    public virtual Proveedor? IdProveedorNavigation { get; set; }

    public virtual ICollection<ProductosPedido> ProductosPedidos { get; set; } = new List<ProductosPedido>();
}
