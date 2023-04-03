using CQRS.Core.Commands;

namespace post.cmd.api.Commands;

public class AddCommentCommand : BaseCommand
{
    public required string Comment { get; set; }
    public required string Username { get; set; }
}

