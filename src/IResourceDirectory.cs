namespace Zenseless.OpenTK.GUI;

internal interface IResourceDirectory
{
    string[] Enumerate();
    
    EmbeddedResource Resource(string name);
}