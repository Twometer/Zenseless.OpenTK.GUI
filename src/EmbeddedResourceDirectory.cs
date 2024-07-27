using System.Reflection;

namespace Zenseless.OpenTK.GUI;

internal class EmbeddedResourceDirectory : IResourceDirectory
{
    private readonly Assembly _assembly = Assembly.GetExecutingAssembly();

    public string[] Enumerate()
    {
        return _assembly.GetManifestResourceNames();
    }

    public EmbeddedResource Resource(string name)
    {
        return new EmbeddedResource(_assembly, name);
    }

}