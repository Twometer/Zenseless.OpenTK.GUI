using System;
using System.IO;
using System.Reflection;

namespace Zenseless.OpenTK.GUI;

internal class EmbeddedResource(Assembly assembly, string name)
{
    public byte[] AsByteArray()
    {
        using var stream = assembly.GetManifestResourceStream(name);
        if (stream == null)
        {
            throw new ArgumentException($"Unknown resource: {name}");
        }
        
        using var memory = new MemoryStream();
        stream.CopyTo(memory);
        return memory.ToArray();
    }
    
}