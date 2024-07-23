﻿#region

using System;
using System.Linq;

#endregion

namespace PluginCore.Attribute;

[AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
public class ConfigField<TEnum> : ConfigField where TEnum : struct, Enum
{
    public ConfigField(string title, string description, int symbol = 0) :
        base(title, description, symbol, ConfigFieldType.自定义选项, Enum.GetValues(typeof(TEnum)).Cast<object>().ToArray())
    {
    }
}

[AttributeUsage(AttributeTargets.Field, AllowMultiple = true, Inherited = true)]
public class ConfigField : System.Attribute
{
    public ConfigField(string title, string description, int symbol = 0,
        ConfigFieldType fieldType = ConfigFieldType.字符串, object[]? options = null, int maxValue = 0, int minValue = 0,
        int step = 0
    )
    {
        Tittle = title;
        Description = description;
        Symbol = symbol;
        FieldType = fieldType;
        Options = options;
        MaxValue = maxValue;
        MinValue = minValue;
        Step = step;
    }

    public string Tittle { get; set; }

    public string Description { get; set; }

    public int Symbol { get; set; }
    public ConfigFieldType FieldType { get; set; }

    public object[]? Options { get; set; }
    public int MaxValue { get; set; }
    public int MinValue { get; set; }
    public int Step { get; set; }
}