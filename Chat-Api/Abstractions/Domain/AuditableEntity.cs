// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Abstractions.Domain;

public abstract class AuditableEntity<TKey> : BaseEntity<TKey>, IAuditableEntity<TKey>
{
    public DateTimeOffset CreatedOnUtc { get; private set; }
    public Guid CreatedBy { get;  private set; }
    public DateTimeOffset UpdatedOnUtc { get; private set; }
    public Guid UpdatedBy { get; private set; }

    public void SetCreated(DateTimeOffset createdOnUtc, Guid createdBy)
    {
        CreatedOnUtc = createdOnUtc;
        CreatedBy = createdBy;
    }

    public void SetUpdated(DateTimeOffset updatedOnUtc, Guid updatedBy)
    {
        UpdatedOnUtc = updatedOnUtc;
        UpdatedBy = updatedBy;
    }

    public void InitializeAuditInfo(DateTimeOffset now, Guid userId)
    {
        var nowUtc = now.UtcDateTime;
        CreatedOnUtc = nowUtc;
        CreatedBy = userId;
        UpdatedOnUtc = nowUtc;
        UpdatedBy = userId;
    }

    public void UpdateAuditInfo(DateTimeOffset now, Guid userId)
    {
        UpdatedOnUtc = now.UtcDateTime;
        UpdatedBy = userId;
    }
}
