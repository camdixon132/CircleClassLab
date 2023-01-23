using System;
namespace CircleObjectsLab
{
	public class Circle
	{
		//Properties
		public double radius { get; set; }

		//Constructors
		public Circle(double _radius)
		{
			radius = _radius;
		}

		//Methods
		public double CalculateCircumference()
		{
			return 2 * Math.PI * radius;
		}
		public string CalculateFormattedCircumference()
		{
			return $"Circumference: {FormatNumber(CalculateCircumference())}";
		}
		public double CalculateArea()
		{
			return radius * radius * Math.PI;
		}
		public string CalculateFormattedArea()
		{
			return $"Area: {FormatNumber(CalculateArea())}";
		}
		private string FormatNumber(double x)
		{
			return Math.Round(x,2) + "";
		}

	}
}

