using System;
namespace test_graphics
{
	public class Animal : SimulationObject
	{
		public Animal(double x, double y) : base(Colors.Red, x, y)
		{
		}

		public override void Update()
		{
			X = X + 5;
		}
	}
}

