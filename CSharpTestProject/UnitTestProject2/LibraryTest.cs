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
			Assert.That(0.0f, Is.EqualTo(p1.X).Within(0.01).Percent);
			Assert.AreEqual(typeof(float), p1.X.GetType());

			var p2 = new Point1<double>(2.0);
			Assert.That(2.0, Is.EqualTo(p2.X).Within(0.01).Percent);
			Assert.AreEqual(typeof(double), p2.X.GetType());
		}

		[Test]
		public void Point2Tests()
		{
			var p1 = new Point2<float>();
			Assert.That(0.0f, Is.EqualTo(p1.X).Within(0.01).Percent);
			Assert.That(0.0f, Is.EqualTo(p1.Y).Within(0.01).Percent);
			Assert.AreEqual(typeof(float), p1.X.GetType());
			Assert.AreEqual(typeof(float), p1.Y.GetType());

			var p2 = new Point2<double>(2.0, 3.5);
			Assert.That(2.0, Is.EqualTo(p2.X).Within(0.01).Percent);
			Assert.That(3.5, Is.EqualTo(p2.Y).Within(0.01).Percent);
			Assert.AreEqual(typeof(double), p2.X.GetType());
			Assert.AreEqual(typeof(double), p2.Y.GetType());
		}

		[Test]
		public void Point3Tests()
		{
			var p1 = new Point3<float>();
			Assert.That(0.0f, Is.EqualTo(p1.X).Within(0.01).Percent);
			Assert.That(0.0f, Is.EqualTo(p1.Y).Within(0.01).Percent);
			Assert.That(0.0f, Is.EqualTo(p1.Z).Within(0.01).Percent);
			Assert.AreEqual(typeof(float), p1.X.GetType());
			Assert.AreEqual(typeof(float), p1.Y.GetType());
			Assert.AreEqual(typeof(float), p1.Z.GetType());

			var p2 = new Point3<double>(2.0, 3.5, 6.7);
			Assert.That(2.0, Is.EqualTo(p2.X).Within(0.01).Percent);
			Assert.That(3.5, Is.EqualTo(p2.Y).Within(0.01).Percent);
			Assert.That(6.7, Is.EqualTo(p2.Z).Within(0.01).Percent);
			Assert.AreEqual(typeof(double), p2.X.GetType());
			Assert.AreEqual(typeof(double), p2.Y.GetType());
			Assert.AreEqual(typeof(double), p2.Z.GetType());
		}

		[Test]
		public void Point1AdditionTests()
		{
			var p1 = new Point1<float>() + new Point1<float>(2.0f);
			Assert.That(2.0f, Is.EqualTo(p1.X).Within(0.01).Percent);
			Assert.AreEqual(typeof(float), p1.X.GetType());

			var p2 = new Point1<double>(2.0) + new Point1<double>(5.0);
			Assert.That(7.0, Is.EqualTo(p2.X).Within(0.01).Percent);
			Assert.AreEqual(typeof(double), p2.X.GetType());
		}

		[Test]
		public void Point2AdditionTests()
		{
			var p1 = new Point2<float>() + new Point2<float>(2.0f, 5.0f);
			Assert.That(2.0f, Is.EqualTo(p1.X).Within(0.01).Percent);
			Assert.That(5.0f, Is.EqualTo(p1.Y).Within(0.01).Percent);
			Assert.AreEqual(typeof(float), p1.X.GetType());
			Assert.AreEqual(typeof(float), p1.Y.GetType());

			var p2 = new Point2<double>(2.0, 3.5) + new Point2<double>(2.0, 5.0);
			Assert.That(4.0, Is.EqualTo(p2.X).Within(0.01).Percent);
			Assert.That(8.5, Is.EqualTo(p2.Y).Within(0.01).Percent);
			Assert.AreEqual(typeof(double), p2.X.GetType());
			Assert.AreEqual(typeof(double), p2.Y.GetType());
		}

		[Test]
		public void Point3AdditionTests()
		{
			var p1 = new Point3<float>() + new Point3<float>(2.0f, 5.0f, 7.0f);
			Assert.That(2.0f, Is.EqualTo(p1.X).Within(0.01).Percent);
			Assert.That(5.0f, Is.EqualTo(p1.Y).Within(0.01).Percent);
			Assert.That(7.0f, Is.EqualTo(p1.Z).Within(0.01).Percent);
			Assert.AreEqual(typeof(float), p1.X.GetType());
			Assert.AreEqual(typeof(float), p1.Y.GetType());
			Assert.AreEqual(typeof(float), p1.Z.GetType());

			var p2 = new Point3<double>(2.0, 3.5, 6.7) + new Point3<double>(2.0, 5.0, 7.0);
			Assert.That(4.0, Is.EqualTo(p2.X).Within(0.01).Percent);
			Assert.That(8.5, Is.EqualTo(p2.Y).Within(0.01).Percent);
			Assert.That(13.7, Is.EqualTo(p2.Z).Within(0.01).Percent);
			Assert.AreEqual(typeof(double), p2.X.GetType());
			Assert.AreEqual(typeof(double), p2.Y.GetType());
			Assert.AreEqual(typeof(double), p2.Z.GetType());
		}

		[Test]
		public void Point1SubtractionTests()
		{
			var p1 = new Point1<float>() - new Point1<float>(2.0f);
			Assert.That(-2.0, Is.EqualTo(p1.X).Within(0.01).Percent);
			Assert.AreEqual(typeof(float), p1.X.GetType());

			var p2 = new Point1<double>(2.0) - new Point1<double>(5.0);
			Assert.That(-3.0, Is.EqualTo(p2.X).Within(0.01).Percent);
			Assert.AreEqual(typeof(double), p2.X.GetType());
		}

		[Test]
		public void Point2SubtractionTests()
		{
			var p1 = new Point2<float>() - new Point2<float>(2.0f, 5.0f);
			Assert.That(-2.0f, Is.EqualTo(p1.X).Within(0.01).Percent);
			Assert.That(-5.0f, Is.EqualTo(p1.Y).Within(0.01).Percent);
			Assert.AreEqual(typeof(float), p1.X.GetType());
			Assert.AreEqual(typeof(float), p1.Y.GetType());

			var p2 = new Point2<double>(2.0, 3.5) - new Point2<double>(2.0, 5.0);
			Assert.That(0.0, Is.EqualTo(p2.X).Within(0.01).Percent);
			Assert.That(-1.5, Is.EqualTo(p2.Y).Within(0.01).Percent);
			Assert.AreEqual(typeof(double), p2.X.GetType());
			Assert.AreEqual(typeof(double), p2.Y.GetType());
		}

		[Test]
		public void Point3SubtractionTests()
		{
			var p1 = new Point3<float>() - new Point3<float>(2.0f, 5.0f, 7.0f);
			Assert.That(-2.0f, Is.EqualTo(p1.X).Within(0.01).Percent);
			Assert.That(-5.0f, Is.EqualTo(p1.Y).Within(0.01).Percent);
			Assert.That(-7.0f, Is.EqualTo(p1.Z).Within(0.01).Percent);
			Assert.AreEqual(typeof(float), p1.X.GetType());
			Assert.AreEqual(typeof(float), p1.Y.GetType());
			Assert.AreEqual(typeof(float), p1.Z.GetType());

			var p2 = new Point3<double>(2.0, 3.5, 6.7) - new Point3<double>(2.0, 5.0, 7.0);
			Assert.That(0.0, Is.EqualTo(p2.X).Within(0.01).Percent);
			Assert.That(-1.5, Is.EqualTo(p2.Y).Within(0.01).Percent);
			Assert.That(-0.3, Is.EqualTo(p2.Z).Within(0.01).Percent);
			Assert.AreEqual(typeof(double), p2.X.GetType());
			Assert.AreEqual(typeof(double), p2.Y.GetType());
			Assert.AreEqual(typeof(double), p2.Z.GetType());
		}
	}
}
