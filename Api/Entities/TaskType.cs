namespace Api.Entities
{
    public class TaskType : BaseEntity
    {
        public string Name { get; set; }
        public int HierarchyPosition { get; set; }
    }
}