using System;

namespace PluginCore;

public class ConfigChangedArgs : EventArgs
{
    public string Name { get; }
    public object? Value { get; }
    public ConfigChangedArgs(string name, object? value)
    {
        Name = name;
        Value = value;
    }
}
public class ConfigBase
{
    public event EventHandler<ConfigChangedArgs> ConfigChanged;
    public void OnConfigChanged(string name, object? value)
    {
        ConfigChanged?.Invoke(this, new ConfigChangedArgs(name, value));
    }
    public string Name { get;init ; }
    public virtual void BeforeLoad()
    {
        
    }
    public virtual void AfterLoad()
    {
        
    }
    public virtual void BeforeSave()
    {
        
    }
    public virtual void AfterSave()
    {
        
    }
    
}