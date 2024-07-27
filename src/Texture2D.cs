using System;
using OpenTK.Graphics.OpenGL;

namespace Zenseless.OpenTK.GUI;

internal class Texture2D : IDisposable
{
    internal int Handle { get; }

    internal TextureWrapMode WrapMode
    {
        set
        {
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapS, (int)value);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapT, (int)value);
        }
    }

    internal TextureMinFilter MinFilter
    {
        set => GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, (int)value);
    }

    internal TextureMagFilter MagFilter
    {
        set => GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter, (int)value);
    }

    internal Texture2D(int width, int height, SizedInternalFormat format, int mipmaps)
    {
        Handle = GL.GenTexture();
        GL.BindTexture(TextureTarget.Texture2D, Handle);
        GL.TexStorage2D(TextureTarget2d.Texture2D, mipmaps, format, width, height);
    }

    public void Dispose()
    {
        GL.DeleteTexture(Handle);
    }
}