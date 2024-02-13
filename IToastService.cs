using Avalonia.Controls;

namespace PluginCore;

public interface IToastService
{
    public void Show(string header, string text);
}