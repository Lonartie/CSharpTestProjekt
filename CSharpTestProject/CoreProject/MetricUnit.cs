using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreProject
{
	public class MetricUnit<TRatio> where TRatio : Ratio
	{
		private double value;

		public MetricUnit() => this.value = 0;
		public MetricUnit(double value) => this.value = value;

		//public int operator implicit()
		//{
		//}
	}
}

public class Ratio
{

}
