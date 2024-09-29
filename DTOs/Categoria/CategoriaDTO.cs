using Sistema_de_Inventario.Models;

namespace Sistema_de_Inventario.DTOs.Categoria
{
    public class CategoriaDTO
    {
        public int CategoriaId { get; set; }
        public string Nombre { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public DateTime FechaCreacion { get; set; }

        public static CategoriaDTO ConvertirACategoriaDTO(Sistema_de_Inventario.Models.Categoria categoria)
        {
            return new CategoriaDTO
            {
                CategoriaId = categoria.CategoriaId,
                Nombre = categoria.Nombre,
                Descripcion = categoria.Descripcion,
                FechaCreacion = (DateTime)categoria.FechaCreacion
            };
        }
    }

}
