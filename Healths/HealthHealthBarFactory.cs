// using Factories;
//
// namespace HealthBars.Healths
// {
//     public class HealthHealthBarFactory<TMaterial> : IFactory<TMaterial, IHealthBar> where TMaterial : IHealthObject
//     {
//         public IFactory<TMaterial, IHealthBar> Impl { get; set; }
//
//         public IHealthBar Create(TMaterial parameters)
//         {
//             var healthBar = Impl.Create(parameters);
//             var health = new HealthBarHealth
//             {
//                 HealthBar = healthBar,
//                 Impl = parameters.Health
//             };
//             parameters.Health = health;
//             return healthBar;
//         }
//     }
// }