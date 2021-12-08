namespace CompositeExample.Shapes
{
    public class ConsoleRectangle : CompoundGraphicElement
    {
        public ConsoleRectangle(string name) : base(name) {}

        public override void Draw()
        {
            System.Console.WriteLine($"Rectangle at {Transform.GetModelMatrix().Translation}");
            base.Draw();
        }
    }
}
