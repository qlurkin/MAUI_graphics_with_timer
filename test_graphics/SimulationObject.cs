using System;
namespace test_graphics
{
    public abstract class SimulationObject : DrawableObject
    {
        public SimulationObject(Color color, double x, double y) : base(color, x, y) {}

        abstract public void Update();
    }
}

