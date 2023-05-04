using System.Numerics;
using HealthBars.Unity;
using UnityEngine.UI;

namespace HealthBars
{
    public class SliderHealthBar : Slider, IHealthBar
    {
        public float MaxValue
        {
            get => maxValue;
            set => maxValue = value;
        }

        public Vector3 Position
        {
            set => transform.position = UnityUtils.Convert(value);
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