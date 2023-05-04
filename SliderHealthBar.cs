using Transforms;
using UnityEngine;
using UnityEngine.UI;
using UnityUtils = HealthBars.Unity.UnityUtils;
using Vector3 = System.Numerics.Vector3;

namespace HealthBars
{
    public class SliderHealthBar : Slider, IHealthBar, ISerializationCallbackReceiver
    {
        public int MaxValue
        {
            set => maxValue = value;
        }

        public ITransform Transform { get; private set; }

        public int Value
        {
            set => this.value = value;
        }

        public bool Visible
        {
            set => gameObject.SetActive(value);
        }

        public void OnBeforeSerialize()
        {
        }

        public void OnAfterDeserialize()
        {
            Transform = new UnityTransform
            {
                Impl = transform
            };
        }
    }
}