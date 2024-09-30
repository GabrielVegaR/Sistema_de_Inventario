namespace Sistema_de_Inventario.DTOs.Proveedor
{
    public class ProveedorDTO
    {
        public int ProveedorId { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaCreacion { get; set; }
        public static ProveedorDTO ConvertirAProveedorDTO(Sistema_de_Inventario.Models.Proveedor proveedor)
        {
            if (proveedor == null)
            {
                return null; 
            }

            return new ProveedorDTO
            {
                ProveedorId = proveedor.ProveedorId,
                Nombre = proveedor.Nombre,
                Email = proveedor.Email,
                Telefono = proveedor.CodigoArea + proveedor.CodigoPais +proveedor.Telefono,
                FechaCreacion = (DateTime)proveedor.FechaCreacion
            };
        }
    }
}
