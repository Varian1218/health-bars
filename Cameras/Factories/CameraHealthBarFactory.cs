using Cameras;
using Factories;

namespace HealthBars.Cameras.Factories
{
    public class CameraHealthBarFactory<T> : IParamsFactory<IHealthBar, T>
    {
        public IParamsFactory<IHealthBar, T> Impl { get; set; }
        public ICamera Camera { get; set; }

        public IHealthBar Create(T parameters)
        {
            return new CameraHealthBar
            {
                Camera = Camera,
                Impl = Impl.Create(parameters)
            };
        }
    }
}