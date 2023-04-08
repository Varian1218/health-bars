using UnityEngine.UI;

namespace HealthBars.Unity
{
    public class SliderHealthBar : Slider, IHealthBar
    {
        public float MaxValue
        {
            get => maxValue;
            set => maxValue = value;
        }

        public float Value
        {
            get => value;
            set => this.value = value;
        }

        public bool Visible
        {
            set => gameObject.SetActive(value);
        }
    }
}