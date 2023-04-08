using UnityEngine;

namespace HealthBars
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
    }
}