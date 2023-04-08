namespace HealthBars
{
    public interface IHealthBarFactory
    {
        IHealthBar CreatHealthBar(string hash);
    }
}