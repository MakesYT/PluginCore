﻿#region

using System;

#endregion

namespace PluginCore.Attribute;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
public class AutoUnbox : System.Attribute
{
}