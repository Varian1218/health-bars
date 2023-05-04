using System.Numerics;
using Cameras;

namespace HealthBars.Cameras
{
    public class CameraHealthBar : IHealthBar
    {
        public ICamera Camera { get; set; }
        public IHealthBar Impl { get; set; }

        public T GetComponent<T>()
        {
            return Impl.GetComponent<T>();
        }

        public float MaxValue
        {
            get => Impl.MaxValue;
            set => Impl.MaxValue = value;
        }

        public Vector3 Position
        {
            set => Impl.Position = Camera.WorldToScreenPoint(value);
        }

        public float Value
        {
            get => Impl.Value;
            set => Impl.Value = value;
        }

        public bool Visible
        {
            set => Impl.Visible = value;
        }
    }
}