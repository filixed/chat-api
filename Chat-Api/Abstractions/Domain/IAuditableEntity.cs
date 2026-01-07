// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Abstractions.Domain;

public interface IAuditableEntity<TKey>
{
    DateTimeOffset CreatedOnUtc { get; }
    Guid CreatedBy { get; }
    DateTimeOffset UpdatedOnUtc { get; }
    Guid UpdatedBy { get; }
}
