using UnityEngine;

namespace HealthBars
{
    public class HealthBar : MonoBehaviour, IHealthBar
    {
        [SerializeField] private Transform fill;
        private float _maxValue;
        private float _value;

        public float MaxValue
        {
            get => _value;
            set
            {
                _maxValue = value;
                UpdateHealthBar();
            }
        }

        public float Value
        {
            get => _value;
            set
            {
                _value = value;
                UpdateHealthBar();
            }
        }

        public bool Visible
        {
            set => gameObject.SetActive(value);
        }

        private void UpdateHealthBar()
        {
            var localScale = fill.localScale;
            localScale.x = _value / _maxValue;
            fill.localScale = localScale;
        }
    }
}