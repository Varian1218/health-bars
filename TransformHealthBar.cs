using System.Numerics;
using Transforms;

namespace HealthBars.Transforms
{
    public class TransformHealthBar : IHealthBar, ITransform
    {
        public IHealthBar HealthBar { get; set; }
        public ITransform Transform { get; set; }

        public T GetComponent<T>()
        {
            return Transform.GetComponent<T>();
        }

        public Vector3 Forward
        {
            get => Transform.Forward;
            set => Transform.Forward = value;
        }

        public Vector3 LocalScale
        {
            get => Transform.LocalScale;
            set => Transform.LocalScale = value;
        }

        public float MaxValue
        {
            get => HealthBar.MaxValue;
            set => HealthBar.MaxValue = value;
        }

        public Vector3 Position
        {
            get => Transform.Position;
            set
            {
                
                Transform.Position = value;
            }
        }

        public float Value
        {
            get => HealthBar.Value;
            set => HealthBar.Value = value;
        }

        public bool Visible
        {
            set => HealthBar.Visible = value;
        }

        public Vector3 Up => Transform.Up;

        public void AddChild(IComponentGetHandler child)
        {
            Transform.AddChild(child);
        }

        public void AddChild(IComponentGetHandler child, bool worldPositionStays)
        {
            Transform.AddChild(child, worldPositionStays);
        }

        public void Destroy()
        {
            Transform.Destroy();
        }
    }
}