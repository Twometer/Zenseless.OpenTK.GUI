using System;
using OpenTK.Graphics.OpenGL;

namespace Zenseless.OpenTK.GUI;

public class Texture2D : IDisposable
{
    public int Handle { get; }

    public TextureWrapMode WrapMode
    {
        set
        {
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapS, (int)value);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapT, (int)value);
        }
    }

    public TextureMinFilter MinFilter
    {
        set => GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, (int)value);
    }

    public TextureMagFilter MagFilter
    {
        set => GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter, (int)value);
    }

    public Texture2D(int width, int height, SizedInternalFormat format, int mipmaps)
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