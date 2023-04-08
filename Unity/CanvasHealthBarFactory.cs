using System.Collections.Generic;
using UnityEngine;

namespace HealthBars.Unity
{
    public class CanvasHealthBarFactory : ICanvasHealthBarFactory
    {
        private readonly Dictionary<string, CanvasHealthBar> _healthBars = new();

        public void AddHealthBar(CanvasHealthBar healthBar, string healthBarHash)
        {
            _healthBars.Add(healthBarHash, healthBar);
        }

        public ICanvasHealthBar CreatHealthBar(string hash)
        {
            return Object.Instantiate(_healthBars[hash]);
        }
    }
}