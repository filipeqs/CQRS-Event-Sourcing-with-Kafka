using CQRS.Core.Commands;

namespace post.cmd.api.Commands;

public class RemoveCommentCommand : BaseCommand
{
    public Guid CommentId { get; set; }
    public required string Username { get; set; }
}

