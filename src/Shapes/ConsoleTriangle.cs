using System;

namespace CompositeExample.Shapes
{
    public class ConsoleTriangle : CompoundGraphicElement
    {
        public ConsoleTriangle(string name) : base(name) {}

        public override void Draw()
        {
            Console.WriteLine($"Triangle at {Transform.GetModelMatrix().Translation}");
            base.Draw();
        }
    }
}
