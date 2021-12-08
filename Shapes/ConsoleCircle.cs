namespace CompositeExample.Shapes
{
    public class ConsoleCircle : CompoundGraphicElement
    {
        public ConsoleCircle(string name) : base(name) {}

        public override void Draw()
        {
            System.Console.WriteLine($"Circle at {Transform.GetModelMatrix().Translation}");
            base.Draw();
        }
    }
}
