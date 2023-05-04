using System.Numerics;
using Cameras;
using Transforms;

namespace HealthBars.Cameras
{
    public class CameraHealthBar : IHealthBar
    {
        public ICamera Camera { get; set; }
        public IHealthBar Impl { get; set; }

        public int MaxValue
        {
            set => Impl.MaxValue = value;
        }

        public ITransform Transform { get; }

        public int Value
        {
            set => Impl.Value = value;
        }

        public bool Visible
        {
            set => Impl.Visible = value;
        }
    }
}