using System.Numerics;
using Transforms;

namespace HealthBars
{
    public interface IHealthBar : IComponentGetHandler
    {
        float MaxValue { get; set; }
        Vector3 Position { set; }
        float Value { get; set; }
        bool Visible { set; }
    }
}