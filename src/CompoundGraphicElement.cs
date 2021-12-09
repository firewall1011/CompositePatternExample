using System;
using System.Collections.Generic;

namespace CompositeExample
{
    public class CompoundGraphicElement : IGraphicElement, ICompound<IGraphicElement>
    {
        public Transform Transform => _transform;
        public readonly string Name;

        private readonly Transform _transform = new();
        private readonly List<IGraphicElement> _children = new();

        public CompoundGraphicElement(string name)
        {
            Name = name;
        }

        public virtual void Draw()
        {
            foreach(var child in _children)
            {
                child.Draw();
            }
            Console.WriteLine(Name + " was drawn");
        }

        public IEnumerable<IGraphicElement> GetChildren() => _children;

        public bool Remove(IGraphicElement element)
        {
            return _children.Remove(element) && _transform.Remove(element.Transform);
        }

        public void Add(IGraphicElement element)
        {
            _children.Add(element);
            _transform.Add(element.Transform);
        }

        public void Add(params IGraphicElement[] elements)
        {
            foreach(var element in elements)
            {
                Add(element);
            }
        }
    }
}
