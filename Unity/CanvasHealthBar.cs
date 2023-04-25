using Cameras;
using Transforms;
using UnityEngine;
using UnityBoosts;
using Vector3 = System.Numerics.Vector3;

namespace HealthBars.Unity
{
    public class CanvasHealthBar : MonoBehaviour, ICanvasHealthBar
    {
        [SerializeField] private ObjectReference<IHealthBar> healthBar;
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

        public IHealthBar HealthBar => healthBar.Value;

        public Vector3 Position
        {
            set
            {
                _position = value;
                UpdatePosition();
            }
        }

        public ITransform Parent
        {
            set => transform.SetParent(value.GetComponent<Transform>(), false);
        }

        private void UpdatePosition()
        {
            transform.position = UnityUtils.Convert(_camera.WorldToScreenPoint(_position));
        }
    }
}