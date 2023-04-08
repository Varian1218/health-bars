using Cameras;
using UnityEngine;
using UnityEngine.UI;
using Vector3 = System.Numerics.Vector3;

namespace HealthBars
{
    public class SliderHealthBar : MonoBehaviour, IHealthBar
    {
        [SerializeField] private Slider slider;
        private ICamera _camera;
        private Vector3 _position;

        public float MaxValue
        {
            get => slider.maxValue;
            set => slider.maxValue = value;
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
            get => slider.value;
            set => slider.maxValue = value;
        }

        public bool Visible
        {
            set => gameObject.SetActive(value);
        }

        private void UpdatePosition()
        {
            transform.position = UnityUtils.Convert(_camera.WorldToScreenPoint(_position));
        }
    }
}