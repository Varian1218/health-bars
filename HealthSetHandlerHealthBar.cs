namespace HealthBars
{
    public class HealthSetHandlerHealthBar : IHealthSetHandler
    {
        public IHealthBar HealthBar { get; set; }
        public IHealthSetHandler Impl { get; set; }

        public int Value
        {
            set
            {
                HealthBar.Value = value;
                Impl.Value = value;
            }
        }
    }
}