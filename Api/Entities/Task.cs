namespace Api.Entities
{
    public class Task : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public TaskType TaskType { get; set; }
        public int TaskTypeId { get; set; }
        public Part Part { get; set; }
        public int PartId { get; set; }
        public int Quantity { get; set; }
        public int StoryPoints { get; set; }
    }
}