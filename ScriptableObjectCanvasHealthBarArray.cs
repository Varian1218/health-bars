using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace HealthBars
{
    [CreateAssetMenu(menuName = "Health Bars/Canvas Health Bar Array", fileName = "Canvas Health Bar Array", order = 1)]
    public class ScriptableObjectCanvasHealthBarArray : ScriptableObject, IEnumerable<CanvasHealthBar>
    {
        [SerializeField] private CanvasHealthBar[] healthBars;

        public IEnumerator<CanvasHealthBar> GetEnumerator()
        {
            return healthBars.Select(it => it).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return healthBars.GetEnumerator();
        }
    }
}