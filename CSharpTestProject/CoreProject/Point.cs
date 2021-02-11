using System;

namespace CoreProject
{
	/// <summary>
	/// 1 dimensional representation of points
	/// </summary>
	/// <typeparam name="T">Type of the point components</typeparam>
	public class Point1<T>
	{
		/* ============ CTORS ============ */

		/// <summary>
		/// Constructor default initializing X with 'default'
		/// </summary>
		public Point1() => X = default;

		/// <summary>
		/// Constructor to initialize X-Component
		/// </summary>
		/// <param name="X">The initial value of X-Component</param>
		public Point1(T X) => this.X = X;

		/* ============ OPERATORS ============ */

		/// <summary>
		/// Addition operator which adds component-wise
		/// </summary>
		/// <param name="a">First point</param>
		/// <param name="b">Second point</param>
		/// <returns>The sum of the two points</returns>
		public static Point1<T> operator +(Point1<T> a, Point1<T> b)
			=> new Point1<T>((dynamic)a.X + b.X);

		/// <summary>
		/// Subtraction operator which subs component-wise
		/// </summary>
		/// <param name="a">First point</param>
		/// <param name="b">Second point</param>
		/// <returns>The difference of the two points</returns>
		public static Point1<T> operator -(Point1<T> a, Point1<T> b)
			=> new Point1<T>((dynamic)a.X - b.X);

		/* ============ METHODS ============ */

		/// <summary>
		/// Calculates the magnitude (length as vector) of the point
		/// </summary>
		/// <returns>The magnitude</returns>
		public virtual T Magnitude()
			=> X;

		/// <summary>
		/// Calculates the normalized Point (normalized points have the same direction but fixed length of 1)
		/// </summary>
		/// <returns>The normalized point</returns>
		public virtual Point1<T> Normalized()
			=> new Point1<T>((dynamic)X / Magnitude());

		/* ============ MEMBERS ============ */

		/// <summary>
		/// X-Component of the Point
		/// </summary>
		public T X;
	}

	/// <summary>
	/// 2 dimensional representation of points
	/// </summary>
	/// <typeparam name="T">Type of the point components</typeparam>
	public class Point2<T> : Point1<T>
	{
		/* ============ CTORS ============ */

		/// <summary>
		/// Constructor default initializing X and Y with 'default'
		/// </summary>
		public Point2() => Y = default;

		/// <summary>
		/// Constructor to initialize X- and Y-Component
		/// </summary>
		/// <param name="X">The initial value of X-Component</param>
		/// <param name="Y">The initial value of Y-Component</param>
		public Point2(T X, T Y)
			: base(X) => this.Y = Y;

		/* ============ OPERATORS ============ */

		/// <summary>
		/// Addition operator which adds component-wise
		/// </summary>
		/// <param name="a">First point</param>
		/// <param name="b">Second point</param>
		/// <returns>The sum of the two points</returns>
		public static Point2<T> operator +(Point2<T> a, Point2<T> b)
			=> new Point2<T>(((a as Point1<T>) + (b as Point1<T>)).X,
				(dynamic)a.Y + b.Y);

		/// <summary>
		/// Subtraction operator which subs component-wise
		/// </summary>
		/// <param name="a">First point</param>
		/// <param name="b">Second point</param>
		/// <returns>The difference of the two points</returns>
		public static Point2<T> operator -(Point2<T> a, Point2<T> b)
			=> new Point2<T>(((a as Point1<T>) - (b as Point1<T>)).X,
				(dynamic)a.Y - b.Y);

		/* ============ METHODS ============ */

		/// <summary>
		/// Calculates the magnitude (length as vector) of the point
		/// </summary>
		/// <returns>The magnitude</returns>
		public override T Magnitude()
			=> Math.Sqrt((dynamic)X * X + (dynamic)Y * Y);

		/// <summary>
		/// Calculates the normalized Point (normalized points have the same direction but fixed length of 1)
		/// </summary>
		/// <returns>The normalized point</returns>
		public new virtual Point2<T> Normalized()
			=> new Point2<T>((dynamic)X / Magnitude(),
				(dynamic)Y / Magnitude());

		/* ============ MEMBERS ============ */

		/// <summary>
		/// Y-Component of the Point
		/// </summary>
		public T Y;
	}

	/// <summary>
	/// 3 dimensional representation of points
	/// </summary>
	/// <typeparam name="T">Type of the point components</typeparam>
	public class Point3<T> : Point2<T>
	{
		/* ============ CTORS ============ */

		/// <summary>
		/// Constructor default initializing X, Y and Z with 'default'
		/// </summary>
		public Point3() => Z = default;

		/// <summary>
		/// Constructor to initialize X-, Y- and Z-Component
		/// </summary>
		/// <param name="X">The initial value of X-Component</param>
		/// <param name="Y">The initial value of Y-Component</param>
		/// <param name="Z">The initial value of Z-Component</param>
		public Point3(T X, T Y, T Z)
			: base(X, Y) => this.Z = Z;

		/* ============ OPERATORS ============ */

		/// <summary>
		/// Addition operator which adds component-wise
		/// </summary>
		/// <param name="a">First point</param>
		/// <param name="b">Second point</param>
		/// <returns>The sum of the two points</returns>
		public static Point3<T> operator +(Point3<T> a, Point3<T> b)
			=> new Point3<T>(((a as Point2<T>) + (b as Point2<T>)).X,
				((a as Point2<T>) + (b as Point2<T>)).Y,
				(dynamic)a.Z + b.Z);

		/// <summary>
		/// Subtraction operator which subs component-wise
		/// </summary>
		/// <param name="a">First point</param>
		/// <param name="b">Second point</param>
		/// <returns>The difference of the two points</returns>
		public static Point3<T> operator -(Point3<T> a, Point3<T> b)
			=> new Point3<T>(((a as Point2<T>) - (b as Point2<T>)).X,
				((a as Point2<T>) - (b as Point2<T>)).Y,
				(dynamic)a.Z - b.Z);

		/* ============ METHODS ============ */

		/// <summary>
		/// Calculates the magnitude (length as vector) of the point
		/// </summary>
		/// <returns>The magnitude</returns>
		public override T Magnitude()
			=> Math.Sqrt((dynamic)X * X + (dynamic)Y * Y + (dynamic)Z * Z);

		/// <summary>
		/// Calculates the normalized Point (normalized points have the same direction but fixed length of 1)
		/// </summary>
		/// <returns>The normalized point</returns>
		public new virtual Point3<T> Normalized()
			=> new Point3<T>((dynamic)X / Magnitude(),
				(dynamic)Y / Magnitude(),
				(dynamic)Z / Magnitude());

		/* ============ MEMBERS ============ */

		/// <summary>
		/// Y-Component of the Point
		/// </summary>
		public T Z;
	}
}
