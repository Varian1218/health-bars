using UnityEngine;
using Vector3 = System.Numerics.Vector3;

namespace HealthBars
{
    public class HealthBarReference : MonoBehaviour, IHealthBar
    {
        [SerializeField] private HealthBar healthBar;

        public float MaxValue
        {
            get => healthBar.Value;
            set => healthBar.Value = value;
        }

        public Vector3 Position
        {
            set => healthBar.Position = value;
        }

        public float Value
        {
            get => healthBar.Value;
            set => healthBar.Value = value;
        }

        public bool Visible
        {
            set => healthBar.Visible = value;
        }
    }
}