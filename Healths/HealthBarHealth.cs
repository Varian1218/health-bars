namespace HealthBars.Healths
{
    public class HealthBarHealth : IHealth
    {
        public IHealthBar HealthBar { get; set; }
        public IHealth Impl { get; set; }

        public int Value
        {
            get => Impl.Value;
            set
            {
                Impl.Value = value;
                HealthBar.Value = value;
            }
        }
    }
}