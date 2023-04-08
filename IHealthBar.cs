using System.Numerics;

namespace HealthBars
{
    public interface IHealthBar
    {
        float MaxValue { get; set; }
        Vector3 Position { set; }
        float Value { get; set; }
        bool Visible { set; }
    }
}