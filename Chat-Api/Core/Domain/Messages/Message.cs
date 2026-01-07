using Abstractions.Domain;

namespace ChatApi.Domain.Messages;

public class Message : AuditableEntity<MessageId>
{
    private Message() { }

    public string Content { get; private set; } = string.Empty;

    public UserId SenderId { get; private set; } = null!;

    public static Message Create(UserId senderId, string content)
    {
        var message = new Message { Id = MessageId.New(), Content = content, SenderId = senderId };

        message.SetCreated(DateTimeOffset.UtcNow, senderId.Value);

        return message;
    }
}
