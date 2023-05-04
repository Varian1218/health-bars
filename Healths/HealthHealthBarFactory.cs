using Factories;

namespace HealthBars.Healths
{
    public class HealthHealthBarFactory<TObject> : IParamsFactory<IHealthBar, TObject> where TObject : IHealthObject
    {
        public IParamsFactory<IHealthBar, TObject> Impl { get; set; }

        public IHealthBar Create(TObject parameters)
        {
            var healthBar = Impl.Create(parameters);
            var health = new HealthBarHealth
            {
                HealthBar = healthBar,
                Impl = parameters.Health
            };
            parameters.Health = health;
            return healthBar;
        }
    }
}