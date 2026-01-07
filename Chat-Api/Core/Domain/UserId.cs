// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Abstractions.Domain;

namespace ChatApi.Domain;

public sealed record UserId : EntityId
{
    private UserId(Guid value) : base(value) { }

    private UserId() { }

    public static UserId New() => new(Guid.NewGuid());
    public static UserId Create(Guid value) => new(value);
}
