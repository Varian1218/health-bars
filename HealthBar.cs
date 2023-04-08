using UnityEngine;
using Vector3 = System.Numerics.Vector3;

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

        public Vector3 Position
        {
            set => transform.position = UnityUtils.Convert(value);
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