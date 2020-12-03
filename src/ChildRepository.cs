using System.Collections.Generic;
using System.Collections.Immutable;

namespace Santa
{
    public class ChildRepository
    {
        readonly Dictionary<string, Child> children = new Dictionary<string, Child>();
        public ImmutableList<Child> All => children.Values.ToImmutableList();

        public Child Find(string name)
        {
            return children[name];
        }

        public void Add(Child child)
        {
            children.Add(child.Name, child);
        }
    }
}