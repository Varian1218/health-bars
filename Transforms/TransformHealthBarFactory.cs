// using Factories;
// using Transforms;
// using Transforms.Objects;
//
// namespace HealthBars.Transforms
// {
//     public class TransformHealthBarFactory<TObject> : IFactory<IHealthBar, TObject>
//         where TObject : ITransformObject
//     {
//         public IFactory<IHealthBar, TObject> Impl { get; set; }
//
//         public IHealthBar Create(TObject parameters)
//         {
//             var healthBar = Impl.Create(parameters);
//             var position = new PositionTransform
//             {
//                 Position = healthBar.Transform,
//                 Impl = parameters.Transform
//             };
//             parameters.Transform = position;
//             return healthBar;
//         }
//     }
// }