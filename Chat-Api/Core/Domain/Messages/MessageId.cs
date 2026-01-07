// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Abstractions.Domain;

namespace ChatApi.Domain.Messages;

public sealed record MessageId : EntityId
{
    private MessageId(Guid value) : base(value) { }

    private MessageId() { }

    public static MessageId New() => new(Guid.NewGuid());
    public static MessageId Create(Guid value) => new(value);
}
