// using System.Numerics;
// using Transforms;
//
// namespace HealthBars
// {
//     public class HealthBarTransform : ITransform
//     {
//         public ITransform HealthBar { get; set; }
//         public ITransform Impl { get; set; }
//
//         public T GetComponent<T>()
//         {
//             return Impl.GetComponent<T>();
//         }
//
//         public Vector3 Forward
//         {
//             get => Impl.Forward;
//             set => Impl.Forward = value;
//         }
//
//         public Vector3 Position
//         {
//             get => Impl.Position;
//             set
//             {
//                 HealthBar.Position = value;
//                 Impl.Position = value;
//             }
//         }
//
//         public Vector3 LocalScale
//         {
//             get => Impl.LocalScale;
//             set => Impl.LocalScale = value;
//         }
//
//         public Vector3 Up => Impl.Up;
//
//         public void AddChild(IComponentGetHandler child)
//         {
//             Impl.AddChild(child);
//         }
//
//         public void AddChild(IComponentGetHandler child, bool worldPositionStays)
//         {
//             Impl.AddChild(child, worldPositionStays);
//         }
//
//         public void Destroy()
//         {
//             Impl.Destroy();
//         }
//     }
// }