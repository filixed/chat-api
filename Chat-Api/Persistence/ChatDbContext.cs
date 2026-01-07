// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.EntityFrameworkCore;

namespace ChatApi.Persistence;

/// <summary>
///     Provides access to the chat database.
/// </summary>
public class ChatDbContext : DbContext
{
    /// <inheritdoc/>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(AssemblyProvider.Assembly);
    }
}
