using System;

namespace CalculatePi
{
	class Program
	{
		static void Main(string[] args)
		{
			var pi = CalculatePI(40);
			Console.WriteLine(pi);
		}

		public static double CalculatePI(double loop, bool printLog = false)
		{
			var radius = 1;
			var lastCircleSection = Math.Sqrt(2);
			var lastPi = 0d;
			for (var index = 3; index <= loop; index++)
			{
				lastCircleSection = CircleSection(lastCircleSection, radius);
				var perimeter = Math.Pow(2, index) * lastCircleSection;
				lastPi = perimeter / (2 * radius);
				if (printLog)
				{
					Console.WriteLine($"[{index}] Pi = {perimeter / (2 * radius)}");
				}
			}
			return lastPi;
		}

		public static double CircleSection(double lastCircleSection, double radius)
		{
			var l = lastCircleSection;
			var r = radius;

			var ls = Math.Pow((l / 2), 2);
			var x = Math.Sqrt(Math.Pow(r, 2) - ls);
			var s = Math.Sqrt(ls + Math.Pow((r - x), 2));

			return s;
		}
	}
}
