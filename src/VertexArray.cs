using System;
using OpenTK.Graphics.OpenGL4;

namespace Zenseless.OpenTK.GUI;

internal class VertexArray : IDisposable
{
    private int Handle { get; }

    internal VertexArray()
    {
        Handle = GL.GenVertexArray();
    }

    public void Bind()
    {
        GL.BindVertexArray(Handle);
    }

    public void Dispose()
    {
        GL.DeleteVertexArray(Handle);
    }
}