using Api.Entities;

namespace Api.Specifications
{
    public class PartsWithTypesSpecification : BaseSpecification<Part>
    {
        public PartsWithTypesSpecification(PartSpecParams partSpecParams) : base(x =>
                (string.IsNullOrEmpty(partSpecParams.Search) || x.Description.ToLower().Contains(partSpecParams.Search)) &&
                (!partSpecParams.TypeId.HasValue || x.PartTypeId == partSpecParams.TypeId)
            )
        {
            AddInclude(x => x.PartType);
            AddOrderBy(x => x.Description);
            ApplyPaging(partSpecParams.PageSize * (partSpecParams.PageIndex - 1), partSpecParams.PageSize);

            if (!string.IsNullOrEmpty(partSpecParams.Sort))
            {
                switch (partSpecParams.Sort)
                {
                    case "spAsc":
                        AddOrderBy(p => p.StoryPoints);
                        break;
                    case "spDesc":
                        AddOrderByDecending(p => p.StoryPoints);
                        break;
                    default:
                        AddOrderBy(n => n.Description);
                        break;
                }
            }
        }

        public PartsWithTypesSpecification(int id) 
            : base(x => x.Id == id)
        {
            AddInclude(x => x.PartType);
        }
    }
}