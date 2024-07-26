using System;
using OpenTK.Graphics.OpenGL4;


namespace Zenseless.OpenTK.GUI;

public class VertexArray : IDisposable
{
    public int Handle { get; }

    public VertexArray()
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