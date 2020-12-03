using System.Linq;
using NUnit.Framework;

namespace Santa.Tests
{
    public class NiceQueryTests
    {
        [Test]
        public void Can_retrieve_the_nice_children()
        {
            var childRepository = new ChildRepository();
            childRepository.Add(new Child("Sally", "Utah", "Doll", Disposition.Nice));
            childRepository.Add(new Child("Debby", "Colorado", "Doll", Disposition.Naughty));
            childRepository.Add(new Child("James", "Wyoming", "Red Rider BB Gun", Disposition.Nice));
            childRepository.Add(new Child("Jesse", "Wyoming", "Colt 45", Disposition.Naughty));

            var niceQuery = new NiceQuery(childRepository);
            var children = niceQuery.Execute();
            
            Assert.That(children.Any(x=>x.Name == "Sally"), Is.True);
            Assert.That(children.Any(x=>x.Name == "James"), Is.True);
            Assert.That(children.Any(x=>x.Name == "Debby"), Is.False);
            Assert.That(children.Any(x=>x.Name == "Jesse"), Is.False);
        }
    }
}