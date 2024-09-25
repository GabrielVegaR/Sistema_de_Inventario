namespace Sistema_de_Inventario.DTOs.Proveedor
{
    public class ProveedorDTO
    {
        public int ProveedorId { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string CodigoArea { get; set; }
        public string CodigoPais { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
