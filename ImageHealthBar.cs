using Cameras;
using UnityEngine;
using UnityEngine.UI;
using Vector3 = System.Numerics.Vector3;

namespace HealthBars
{
    public class ImageHealthBar : MonoBehaviour, IHealthBar
    {
        [SerializeField] private Image image;
        private ICamera _camera;
        private float _maxValue;
        private Vector3 _position;
        private float _value;

        public ICamera Camera
        {
            set
            {
                _camera = value;
                UpdatePosition();
            }
        }

        public float MaxValue
        {
            get => _maxValue;
            set
            {
                _maxValue = value;
                UpdateFillAmount();
            }
        }

        public Vector3 Position
        {
            set
            {
                _position = value;
                UpdatePosition();
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

        public bool Visible
        {
            set => gameObject.SetActive(value);
        }

        private void UpdateFillAmount()
        {
            image.fillAmount = _value / _maxValue;
        }

        private void UpdatePosition()
        {
            transform.position = UnityUtils.Convert(_camera.WorldToScreenPoint(_position));
        }
    }
}