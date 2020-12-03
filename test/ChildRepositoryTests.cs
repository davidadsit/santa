using NUnit.Framework;

namespace Santa.Tests
{
    public class ChildRepositoryTests
    {
        [Test]
        public void Can_retrieve_a_stored_child()
        {
            var childRepository = new ChildRepository();
            var child = new Child("Sally", "location", "gift", Disposition.Nice);
            childRepository.Add(child);
            var foundChild = childRepository.Find(child.Name);
            Assert.That(foundChild, Is.SameAs(child));
        }
    }
}