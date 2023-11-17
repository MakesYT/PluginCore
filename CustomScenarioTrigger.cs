using CommunityToolkit.Mvvm.Messaging;

namespace PluginCore;

public class CustomScenarioTrigger
{
    protected static void Excite(PluginInfo pluginInfo, string name)
    {
        WeakReferenceMessenger.Default.Send($"{pluginInfo.ToPlgString()}_{name}", "CustomScenarioTrigger");
    }
}