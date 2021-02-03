using CoreProject;
using NUnit.Framework;

namespace UnitTestProject2
{
	[TestFixture]
    public class LibraryTest
    {
	    [Test]
	    public void Point1Tests()
	    {
		    var p1 = new Point1<float>();
			Assert.AreEqual(0.0f, p1.X);
			Assert.AreEqual(typeof(float), p1.X.GetType());

			var p2 = new Point1<double>(2.0);
			Assert.AreEqual(2.0, p2.X);
			Assert.AreEqual(typeof(double), p2.X.GetType());
	    }

	    [Test]
	    public void Point2Tests()
	    {
		    var p1 = new Point2<float>();
		    Assert.AreEqual(0.0f, p1.X);
		    Assert.AreEqual(0.0f, p1.Y);
		    Assert.AreEqual(typeof(float), p1.X.GetType());
		    Assert.AreEqual(typeof(float), p1.Y.GetType());

		    var p2 = new Point2<double>(2.0, 3.5);
		    Assert.AreEqual(2.0, p2.X);
		    Assert.AreEqual(3.5, p2.Y);
		    Assert.AreEqual(typeof(double), p2.X.GetType());
		    Assert.AreEqual(typeof(double), p2.Y.GetType());
	    }

	    [Test]
	    public void Point3Tests()
	    {
		    var p1 = new Point3<float>();
		    Assert.AreEqual(0.0f, p1.X);
		    Assert.AreEqual(0.0f, p1.Y);
		    Assert.AreEqual(0.0f, p1.Z);
		    Assert.AreEqual(typeof(float), p1.X.GetType());
		    Assert.AreEqual(typeof(float), p1.Y.GetType());
		    Assert.AreEqual(typeof(float), p1.Z.GetType());

		    var p2 = new Point3<double>(2.0, 3.5, 6.7);
		    Assert.AreEqual(2.0, p2.X);
		    Assert.AreEqual(3.5, p2.Y);
		    Assert.AreEqual(6.7, p2.Z);
		    Assert.AreEqual(typeof(double), p2.X.GetType());
		    Assert.AreEqual(typeof(double), p2.Y.GetType());
		    Assert.AreEqual(typeof(double), p2.Z.GetType());
	    }
    }
}
