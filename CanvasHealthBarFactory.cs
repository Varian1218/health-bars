using System.Collections.Generic;
using UnityEngine;

namespace HealthBars
{
    public class CanvasHealthBarFactory : IHealthBarFactory
    {
        private readonly Dictionary<string, CanvasHealthBar> _healthBars = new();

        public void AddHealthBar(CanvasHealthBar healthBar, string healthBarHash)
        {
            _healthBars.Add(healthBarHash, healthBar);
        }

        public IHealthBar CreatHealthBar(string hash)
        {
            return Object.Instantiate(_healthBars[hash]);
        }
    }
}