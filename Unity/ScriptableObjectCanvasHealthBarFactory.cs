using UnityEngine;

namespace HealthBars.Unity
{
    [CreateAssetMenu(
        menuName = "Health Bars/Canvas Health Bar Factory",
        fileName = "Canvas Health Bar Factory",
        order = 1
    )]
    public class ScriptableObjectCanvasHealthBarFactory : ScriptableObject, ICanvasHealthBarFactory
    {
        private ICanvasHealthBarFactory _impl;

        public ICanvasHealthBarFactory Impl
        {
            set => _impl = value;
        }

        public ICanvasHealthBar CreatHealthBar(string hash)
        {
            return _impl.CreatHealthBar(hash);
        }
    }
}