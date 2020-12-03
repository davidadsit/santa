using NUnit.Framework;

namespace Santa.Tests
{
    public class AddChildCommandTests
    {
        [Test]
        public void Add_stores_the_child()
        {
            var childRepository = new ChildRepository();
            var addChildCommand = new AddChildCommand(childRepository);
            var childName = "Bobby";
            var child = new Child(childName, "location", "gift", Disposition.Nice);
            addChildCommand.Execute(child);

            var storedChild = childRepository.Find(child.Name);
            Assert.That(storedChild, Is.SameAs(child));
        }
    }
}