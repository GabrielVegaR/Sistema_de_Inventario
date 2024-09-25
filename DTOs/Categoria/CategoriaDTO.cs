namespace Sistema_de_Inventario.DTOs.Categoria
{
    public class CategoriaDTO
    {
        public int CategoriaId { get; set; }
        public string Nombre { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public DateTime FechaCreacion { get; set; }
    }
}
