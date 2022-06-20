namespace ValtikCA.Application.Responses
{
    public class OrdenResponse
    {
        public decimal IdOrden { get; set; }
        public decimal IdCliente { get; set; }
        public int Cantidad { get; set; }
        public string? DireccionEnvio { get; set; }
        public string FechaOrden { get; set; } = null!;
        public string EstadoOrden { get; set; } = null!;
    }
}
