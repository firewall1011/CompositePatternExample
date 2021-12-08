using System;

namespace CompositeExample.Shapes
{
    public class Leaf : IGraphicElement
    {
        public Transform Transform => _transform;
        private Transform _transform = new();

        public void Draw()
        {
            Console.WriteLine($"Leaf (can't have children) at {_transform.GetModelMatrix().Translation}");
        }
    }
}
