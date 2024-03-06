#region

using System;

#endregion

namespace PluginCore.Attribute;

[AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
public class ConfigField : System.Attribute
{
    public ConfigField(string title, string description, int symbol = 0, object? defaultValue = null, ConfigFieldType fieldType = ConfigFieldType.字符串, object[]? options = null , ConfigFieldExBase configFieldEx = null)
    {
        Tittle = title;
        Description = description;
        Symbol = symbol;
        DefaultValue = defaultValue;
        FieldType = fieldType;
        Options = options;
        ConfigFieldEx = configFieldEx;
        
    }
    
    public string Tittle
    {
        get;
        set;
    }

    public string Description
    {
        get;
        set;
    }
    
    public int Symbol
    {
        get;
        set;
    }
    public object? DefaultValue
    {
        get;
        set;
    }
    public ConfigFieldType FieldType
    {
        get;
        set;
    }
    public object[]? Options
    {
        get;
        set;
    }
    public ConfigFieldExBase ConfigFieldEx
    {
        get;
        set;
    }
}