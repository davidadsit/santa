using System;

namespace Santa
{
    public class AddChildCommand
    {
        private readonly ChildRepository childRepository;

        public AddChildCommand(ChildRepository childRepository)
        {
            this.childRepository = childRepository;
        }

        public void Execute(Child child)
        {
            childRepository.Add(child);
            Console.Out.WriteLine($"Added {child.Name} who is in {child.Location} and wants a {child.Gift} and is {child.Disposition}");
        }
    }
}