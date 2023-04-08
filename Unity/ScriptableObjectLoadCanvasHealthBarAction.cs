using UnityEngine;

namespace HealthBars.Unity
{
    [CreateAssetMenu(
        menuName = "Health Bars/Load Canvas Health Bar Action",
        fileName = "Load Canvas Health Bar Action",
        order = 1
    )]
    public class ScriptableObjectLoadCanvasHealthBarAction : ScriptableObject
    {
        [SerializeField] private ScriptableObjectCanvasHealthBarArray array;
        [SerializeField] private ScriptableObjectCanvasHealthBarFactory factory;

        public void Invoke()
        {
            var f = new CanvasHealthBarFactory();
            factory.Impl = f;
            foreach (var (healthBar, hash) in array)
            {
                f.AddHealthBar(healthBar, hash);
            }
        }
    }
}