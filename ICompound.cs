using System.Collections.Generic;

namespace CompositeExample
{
    public interface ICompound<T>
    {
        void Add(T component);
        bool Remove(T component);
        IEnumerable<T> GetChildren();
    }
}
