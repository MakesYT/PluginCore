﻿using System;
using System.Text.Json.Serialization;
using Core.SDKs.HotKey;

namespace PluginCore;

public enum HotKeyType
{
    Keyboard,
    Mouse
}

/// <summary>
///     快捷键模型
/// </summary>
public struct HotKeyModel
{
    public bool IsEnabled { get; set; } = true;
    public HotKeyType Type { get; init; } = HotKeyType.Keyboard;
    public ushort? MouseButton { get; init; } = ushort.MaxValue;
    public ushort PressTimeMillis { get; init; } = 1000;

    public HotKeyModel()
    {
        UUID = Guid.NewGuid().ToString();
    }

    [Obsolete("此方法仅供Json反序列化使用")]
    public HotKeyModel(string uuid)
    {
        UUID = uuid;
    }

    public string UUID { get; init; }
    public string? MainName { get; init; }

    /// <summary>
    ///     设置项名称
    /// </summary>
    public string? Name { get; init; }

    /// <summary>
    ///     是否勾选Ctrl按键
    /// </summary>
    public bool IsSelectCtrl { get; init; }

    /// <summary>
    ///     是否勾选Shift按键
    /// </summary>
    public bool IsSelectShift { get; init; }

    /// <summary>
    ///     是否勾选Alt按键
    /// </summary>
    public bool IsSelectAlt { get; init; }

    /// <summary>
    ///     是否勾选Alt按键
    /// </summary>
    public bool IsSelectWin { get; init; }

    /// <summary>
    ///     选中的按键
    /// </summary>
    public EKey SelectKey { get; init; }


    /// <summary>
    ///     快捷键按键集合
    /// </summary>
    public static Array Keys => Enum.GetValues(typeof(EKey));


    [JsonIgnore] public string SignName => $"{this.MainName}_{this.Name}";
}