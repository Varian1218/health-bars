using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace HealthBars.Unity
{
    [CreateAssetMenu(menuName = "Health Bars/Canvas Health Bar Array", fileName = "Canvas Health Bar Array", order = 1)]
    public class ScriptableObjectCanvasHealthBarArray : ScriptableObject, IEnumerable<(CanvasHealthBar, string)>
    {
        [SerializeField] private CanvasHealthBar[] healthBars;

        public IEnumerator<(CanvasHealthBar, string)> GetEnumerator()
        {
            return healthBars.Select(it => (it, it.name)).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return healthBars.GetEnumerator();
        }
    }
}