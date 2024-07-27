using System;
using System.Linq;

namespace Zenseless.OpenTK.GUI;

internal class ShortestMatchResourceDirectory(IResourceDirectory inner) : IResourceDirectory
{
    private string[] _names = inner.Enumerate();
    
    public string[] Enumerate()
    {
        return _names;
    }

    public EmbeddedResource Resource(string name)
    {
        var resolvedName = _names.OrderBy(knownName => knownName.Length).FirstOrDefault(knownName => knownName.Contains(name));
        if (resolvedName == null)
        {
            throw new ArgumentException($"No resource matching '{name}' found");
        }

        return inner.Resource(resolvedName);
    }
}