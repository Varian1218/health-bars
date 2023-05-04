using Transforms;

namespace HealthBars
{
    public interface IHealthBar
    {
        int MaxValue { set; }
        ITransform Transform { get; }
        int Value { set; }
        bool Visible { set; }
    }
}