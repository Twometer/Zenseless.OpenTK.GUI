using OpenTK.Mathematics;

namespace Zenseless.OpenTK.GUI;

public static class Helpers
{
    public static Vector2 ToOpenTK(this System.Numerics.Vector2 vec) => new(vec.X, vec.Y);
    public static Vector3 ToOpenTK(this System.Numerics.Vector3 vec) => new(vec.X, vec.Y, vec.Z);
    public static Vector4 ToOpenTK(this System.Numerics.Vector4 vec) => new(vec.X, vec.Y, vec.Z, vec.W);
    
    public static System.Numerics.Vector2 ToSystemNumerics(this Vector2 vec) => new(vec.X, vec.Y);
    public static System.Numerics.Vector3 ToSystemNumerics(this Vector3 vec) => new(vec.X, vec.Y, vec.Z);
    public static System.Numerics.Vector4 ToSystemNumerics(this Vector4 vec) => new(vec.X, vec.Y, vec.Z, vec.W);
    
}