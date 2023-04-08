using UnityEngine;

namespace HealthBars
{
    [CreateAssetMenu(
        menuName = "Health Bars/Canvas Health Bar Factory",
        fileName = "Canvas Health Bar Factory",
        order = 1
    )]
    public class ScriptableObjectCanvasHealthBarFactory : ScriptableObject, IHealthBarFactory
    {
        private IHealthBarFactory _impl;

        public IHealthBarFactory Impl
        {
            set => _impl = value;
        }

        public IHealthBar CreatHealthBar(string hash)
        {
            return _impl.CreatHealthBar(hash);
        }
    }
}