namespace CompositeExample
{
    public interface IGraphicElement
    {
        Transform Transform { get; }
        void Draw();
    }
}
