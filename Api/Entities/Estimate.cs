namespace Api.Entities
{
    public class Estimate : BaseEntity
    {
        public Proyect Proyect { get; set; }
        public int ProyectId { get; set; }
        public Task Task { get; set; }
        public int TaskId { get; set; }
    }
}