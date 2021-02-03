using System;

namespace CoreProject
{
	public class Point1<T>
	{
		public T X;
		public Point1() 
			=> X = default;
		public Point1(T X = default)
			=> this.X = X;

		public static Point1<T> operator +(Point1<T> a, Point1<T> b) 
			=> new Point1<T>((dynamic)a.X + b.X);
		public static Point1<T> operator -(Point1<T> a, Point1<T> b) 
			=> new Point1<T>((dynamic)a.X + b.X);

		public virtual T Magnitude() 
			=> X;
		public virtual Point1<T> Normalized() 
			=> new Point1<T>((dynamic) X / Magnitude());
	}

	public class Point2<T> : Point1<T>
	{
		public T Y;
		public Point2() : base() 
			=> Y = default;
		public Point2(T X = default, T Y = default) : base(X) 
			=> this.Y = Y;
		public static Point2<T> operator +(Point2<T> a, Point2<T> b) 
			=> new Point2<T>(((a as Point1<T>) + (b as Point1<T>)).X, (dynamic)a.Y + b.Y);
		public static Point2<T> operator -(Point2<T> a, Point2<T> b) 
			=> new Point2<T>(((a as Point1<T>) - (b as Point1<T>)).X, (dynamic)a.Y - b.Y);

		public virtual T Magnitude()
			=> Math.Sqrt((dynamic)X * X + (dynamic)Y * Y);
		public virtual Point2<T> Normalized() 
			=> new Point2<T>((dynamic) X / Magnitude(), (dynamic) Y / Magnitude());
	}

	public class Point3<T> : Point2<T>
	{
		public T Z;
		public Point3() : base() 
			=> Z = default;
		public Point3(T X = default, T Y = default, T Z = default) : base(X, Y)
			=> this.Z = Z;
		public static Point3<T> operator +(Point3<T> a, Point3<T> b) 
			=> new Point3<T>(((a as Point2<T>) + (b as Point2<T>)).X, ((a as Point2<T>) + (b as Point2<T>)).Y, (dynamic)a.Z + b.Z);
		public static Point3<T> operator -(Point3<T> a, Point3<T> b) 
			=> new Point3<T>(((a as Point2<T>) - (b as Point2<T>)).X, ((a as Point2<T>) - (b as Point2<T>)).Y, (dynamic)a.Z - b.Z);
		
		public virtual T Magnitude() 
			=> Math.Sqrt((dynamic)X * X + (dynamic)Y * Y + (dynamic)Z * Z);
		public virtual Point3<T> Normalized() 
			=> new Point3<T>((dynamic) X / Magnitude(), (dynamic) Y / Magnitude(), (dynamic) Z / Magnitude());
	}
}
