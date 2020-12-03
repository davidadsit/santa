using System.Collections.Immutable;
using System.Linq;

namespace Santa
{
    public class NiceQuery
    {
        private readonly ChildRepository childRepository;

        public NiceQuery(ChildRepository childRepository)
        {
            this.childRepository = childRepository;
        }

        public ImmutableList<Child> Execute()
        {
            return childRepository.All.Where(x => x.Disposition == Disposition.Nice).ToImmutableList();
        }
    }
}