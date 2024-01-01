using Avalonia.Controls;

namespace PluginCore;

public interface IToastService
{
    public void Init(TopLevel mainWindow);
    public void Show(string header, string text);
}