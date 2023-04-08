using System.Numerics;
using Cameras;
using Transforms;

namespace HealthBars
{
    public interface ICanvasHealthBar
    {
        ICamera Camera { set; }
        IHealthBar HealthBar { get; }
        Vector3 Position { set; }
        ITransform Parent { set; }
    }
}