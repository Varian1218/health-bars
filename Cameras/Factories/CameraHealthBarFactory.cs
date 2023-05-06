using Cameras;
using Factories;

namespace HealthBars.Cameras.Factories
{
    public class CameraHealthBarFactory<TMaterial> : IFactory<TMaterial, IHealthBar>
    {
        public IFactory<TMaterial, IHealthBar> Impl { get; set; }
        public ICamera Camera { get; set; }

        public IHealthBar Create(TMaterial material)
        {
            return new CameraHealthBar
            {
                Camera = Camera,
                Impl = Impl.Create(material)
            };
        }
    }
}