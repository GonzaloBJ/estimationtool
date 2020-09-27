namespace Api.Entities
{
    public class Part : BaseEntity
    {
        public string Description { get; set; }
        public PartType PartType { get; set; }
        public int PartTypeId { get; set; }
        public int StoryPoints { get; set; }
    }
}