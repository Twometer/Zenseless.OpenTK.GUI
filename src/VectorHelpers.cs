using OpenTK.Mathematics;

namespace Zenseless.OpenTK.GUI;

/// <summary>
/// Helps to convert between the Vector types from OpenTK.Mathematics and System.Numerics
/// </summary>
public static class VectorHelpers
{
    /// <summary>
    /// Converts vec to an OpenTK vector
    /// </summary>
    /// <param name="vec">System.Numerics vector</param>
    /// <returns>OpenTK vector with the same values</returns>
    public static Vector2 ToOpenTK(this System.Numerics.Vector2 vec) => new(vec.X, vec.Y);

    /// <summary>
    /// Converts vec to an OpenTK vector
    /// </summary>
    /// <param name="vec">System.Numerics vector</param>
    /// <returns>OpenTK vector with the same values</returns>
    public static Vector3 ToOpenTK(this System.Numerics.Vector3 vec) => new(vec.X, vec.Y, vec.Z);

    /// <summary>
    /// Converts vec to an OpenTK vector
    /// </summary>
    /// <param name="vec">System.Numerics vector</param>
    /// <returns>OpenTK vector with the same values</returns>
    public static Vector4 ToOpenTK(this System.Numerics.Vector4 vec) => new(vec.X, vec.Y, vec.Z, vec.W);

    /// <summary>
    /// Converts vec to a System.Numerics vector
    /// </summary>
    /// <param name="vec">OpenTK vector</param>
    /// <returns>System.Numerics vector with the same values</returns>
    public static System.Numerics.Vector2 ToSystemNumerics(this Vector2 vec) => new(vec.X, vec.Y);

    /// <summary>
    /// Converts vec to a System.Numerics vector
    /// </summary>
    /// <param name="vec">OpenTK vector</param>
    /// <returns>System.Numerics vector with the same values</returns>
    public static System.Numerics.Vector3 ToSystemNumerics(this Vector3 vec) => new(vec.X, vec.Y, vec.Z);

    /// <summary>
    /// Converts vec to a System.Numerics vector
    /// </summary>
    /// <param name="vec">OpenTK vector</param>
    /// <returns>System.Numerics vector with the same values</returns>
    public static System.Numerics.Vector4 ToSystemNumerics(this Vector4 vec) => new(vec.X, vec.Y, vec.Z, vec.W);
}