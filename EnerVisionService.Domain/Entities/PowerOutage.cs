namespace EnerVisionService.Domain.Entities
{
    public class PowerOutage
    {
        public int Id { get; set; }
        public string Bairro { get; set; } = string.Empty;
        public DateTime Inicio { get; set; }
        public DateTime? Fim { get; set; }
        public string Prejuizos { get; set; } = string.Empty;
    }
}