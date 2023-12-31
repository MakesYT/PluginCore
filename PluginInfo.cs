﻿using System.Drawing;

namespace PluginCore;

public class PluginInfo
{
    public string PluginName
    {
        set;
        get;
    }

    public string PluginId
    {
        set;
        get;
    }

    public string Description
    {
        set;
        get;
    }

    public string Author
    {
        set;
        get;
    }

    public int VersionInt
    {
        set;
        get;
    }

    public string Version
    {
        set;
        get;
    }

    public bool IsEnabled
    {
        set;
        get;
    }

    public string Error
    {
        set;
        get;
    }

    public string Path
    {
        set;
        get;
    }

    public Icon Icon
    {
        set;
        get;
    }


    public string ToPlgString() => $"{Author}_{PluginId}";
}