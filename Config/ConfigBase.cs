﻿using System;

namespace PluginCore.Config;

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
    public void OnConfigChanged(object sender,string name, object? value)
    {
        ConfigChanged?.Invoke(sender, new ConfigChangedArgs(name, value));
    }
    public string Name { get;set; }
    public static ConfigBase Instance;
    

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