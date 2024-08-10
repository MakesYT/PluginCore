using System.Drawing;
using CommunityToolkit.Mvvm.ComponentModel;

namespace PluginCore;

[ObservableObject]
public partial class PluginInfo
{
    public string PluginName { set; get; }

    public string PluginId { set; get; }

    public string Description { set; get; }

    public string Author { set; get; }

    public int VersionInt { set; get; }

    public string Version { set; get; }

    [ObservableProperty] public bool isEnabled;
    [ObservableProperty] public bool unloadFailed;

    public string Error { set; get; }

    public string Path { set; get; }

    public Icon Icon { set; get; }
    public bool IsLocalPlugin { set; get; }


    public string ToPlgString() => $"{Author}_{PluginId}";

    public override string ToString()
    {
        return ToPlgString();
    }
}