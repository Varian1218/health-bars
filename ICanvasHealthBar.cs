using Cameras;

namespace HealthBars
{
    public interface ICanvasHealthBar
    {
        ICamera Camera { set; }
        IHealthBar HealthBar { get; }
    }
}