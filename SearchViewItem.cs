#region

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using Pinyin.NET;
using Bitmap = Avalonia.Media.Imaging.Bitmap;

#endregion

namespace PluginCore;

public partial class SearchViewItem : ObservableObject, IDisposable
{
    [ObservableProperty] private Bitmap? _icon;
    [ObservableProperty] public bool _isStared = false;

    public string? ItemDisplayName
    {
        get;
        set;
    }

    public bool? IsVisible
    {
        set;
        get;
    }

    public bool IsPined
    {
        set;
        get;
    } = false;

    public PinyinItem? PinyinItem
    {
        set;
        get;
    }

    public FileType FileType
    {
        set;
        get;
    }

    public string? Arguments
    {
        set;
        get;
    }

    public string OnlyKey
    {
        set;
        get;
    } = "";

    public int IconSymbol
    {
        set;
        get;
    }


    public string? IconPath
    {
        set;
        get;
    }

    public Action<SearchViewItem?>? Action
    {
        set;
        get;
    }

    public Func<SearchViewItem, Bitmap>? GetIconAction
    {
        set;
        get;
    }


    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
    }
}

public enum FileType
{
    应用程序,
    URL,
    Word文档,
    PPT文档,
    Excel文档,
    PDF文档,
    图像,
    剪贴板图像,
    文件夹,
    文件,
    命令,
    数学运算,
    UWP应用,
    自定义情景,
    便签,
    自定义,
    文本,
    None
}