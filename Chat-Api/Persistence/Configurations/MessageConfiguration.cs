// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using ChatApi.Domain;
using ChatApi.Domain.Messages;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ChatApi.Persistence.Configurations;

public class MessageConfiguration : IEntityTypeConfiguration<Message>
{
    public void Configure(EntityTypeBuilder<Message> builder)
    {
        builder.ToTable("messages");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .HasConversion(x => x.Value, value => MessageId.Create(value));

        builder.Property(x => x.Content)
            .HasMaxLength(255)
            .IsRequired();

        builder.Property(x => x.SenderId)
            .HasConversion(x => x.Value, value => UserId.Create(value));
    }
}
