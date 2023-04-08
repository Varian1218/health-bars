using System;
using Cameras;
using UnityEngine;
using UnityEngine.Events;
using Vector3 = System.Numerics.Vector3;

namespace HealthBars
{
    public class CanvasHealthBar : MonoBehaviour, IHealthBar
    {
        [SerializeField] private UnityEvent<float> setMaxValue;
        [SerializeField] private UnityEvent<float> setValue;
        private ICamera _camera;
        private Vector3 _position;

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
            get => throw new NotImplementedException();
            set => setMaxValue.Invoke(value);
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
            get => throw new NotImplementedException();
            set => setValue.Invoke(value);
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