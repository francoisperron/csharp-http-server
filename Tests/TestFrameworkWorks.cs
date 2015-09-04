using Learning;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    class TestFrameworkWorks
    {
        [Test]
        public void ItWorks()
        {
            Assert.That(new Homer().Says(), Is.EqualTo("DOH"));
        }
    }
}
