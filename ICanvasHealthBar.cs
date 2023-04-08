using System.Numerics;
using Cameras;

namespace HealthBars
{
    public interface ICanvasHealthBar
    {
        ICamera Camera { set; }
        IHealthBar HealthBar { get; }
        Vector3 Position { set; }
    }
}