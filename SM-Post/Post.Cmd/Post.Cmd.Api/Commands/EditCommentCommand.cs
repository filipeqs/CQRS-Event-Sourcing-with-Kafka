using CQRS.Core.Commands;

namespace post.cmd.api.Commands;

public class EditCommentCommand : BaseCommand
{
    public Guid CommentId { get; set; }
    public required string Comment { get; set; }
    public required string Username { get; set; }
}

