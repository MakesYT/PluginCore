using Avalonia.Controls;

namespace PluginCore;

public interface IToastService
{
    public void Init();
    public void Show(string header, string text);
    public void Unregister();
}