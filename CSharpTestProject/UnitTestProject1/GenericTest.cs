using NUnit.Framework;

namespace UnitTestProject1
{
	[TestFixture]
    public class GenericTest
    {
        [Test]
        public void GoodTest()
		{
            Assert.AreEqual(3, 1 + 2);
		}

        [Test]
        public void BadTest()
		{
            Assert.AreEqual(2, 1 + 2);
		}
    }
}
