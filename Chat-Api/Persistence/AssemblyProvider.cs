// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Reflection;

namespace ChatApi.Persistence;

/// <summary>
/// Provides access to the assembly containing the persistence layer.
/// </summary>
public static class AssemblyProvider
{
    /// <summary>
    /// Gets the assembly containing the persistence layer.
    /// </summary>
    public static Assembly Assembly => typeof(AssemblyProvider).Assembly;
}
