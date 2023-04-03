namespace HealthBars
{
    public interface IHealthBar
    {
        float MaxValue { get; set; }
        float Value { get; set; }
        bool Visible { set; }
    }
}