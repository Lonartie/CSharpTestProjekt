using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreProject
{
	public class Point1<T>
	{
		public T X;
		public Point1() => X = default;
		public Point1(T X = default) => this.X = X;
	}

	public class Point2<T> : Point1<T>
	{
		public T Y;
		public Point2() : base() => Y = default;
		public Point2(T X = default, T Y = default) : base(X) => this.Y = Y;
	}

	public class Point3<T> : Point2<T>
	{
		public T Z;
		public Point3() : base() => Z = default;
		public Point3(T X = default, T Y = default, T Z = default) : base(X, Y) => this.Z = Z;
	}
}
