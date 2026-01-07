// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Abstractions.Domain;

public abstract record EntityId
{
    public Guid Value { get; init; }

    protected EntityId() { } // EF / JSON

    protected EntityId(Guid value)
    {
        if (value == Guid.Empty)
            throw new ArgumentException("ID cannot be empty.", nameof(value));

        Value = value;
    }

    public bool IsEmpty() => Value == Guid.Empty;
    public override string ToString() => Value.ToString("D");
}
