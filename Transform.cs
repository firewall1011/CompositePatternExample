using System.Collections.Generic;
using System.Numerics;

namespace CompositeExample
{
    public class Transform : IModelMatrix, ICompound<Transform>
    {
        public Vector3 Position { get; set; } = Vector3.Zero;
        public Vector3 Rotation { get; set; } = Vector3.Zero;
        public Vector3 Scale { get; set; } = Vector3.One;

        public Transform Parent
        {
            get => _parent;
            set
            {
                _parent?.Remove(this);
                _parent = value;
            }
        }

        private Transform _parent;
        private readonly List<Transform> _children = new();

        public Matrix4x4 GetModelMatrix() 
        {
            var model = Matrix4x4.Identity 
                * Matrix4x4.CreateFromYawPitchRoll(Rotation.X, Rotation.Y, Rotation.Z) 
                * Matrix4x4.CreateScale(Scale) 
                * Matrix4x4.CreateTranslation(Position);

            if(Parent is not null)
            {
                model *= Parent.GetModelMatrix();
            }

            return model;
        }

        public void Add(Transform component)
        {
            component.Parent = this;
            _children.Add(component);
        }

        public bool Remove(Transform component)
        {
            component.Parent = null;
            return _children.Remove(component);
        }

        public IEnumerable<Transform> GetChildren() => _children;
    }
}