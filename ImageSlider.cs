using UnityEngine;
using UnityEngine.UI;

namespace HealthBars
{
    public class ImageSlider : MonoBehaviour
    {
        [SerializeField] private Image image;
        private float _maxValue;
        private float _value;

        public float MaxValue
        {
            get => _maxValue;
            set
            {
                _maxValue = value;
                UpdateFillAmount();
            }
        }

        public float Value
        {
            get => _value;
            set
            {
                _value = value;
                UpdateFillAmount();
            }
        }

        private void UpdateFillAmount()
        {
            image.fillAmount = _value / _maxValue;
        }
    }
}