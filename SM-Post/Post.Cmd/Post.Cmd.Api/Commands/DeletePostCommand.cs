using CQRS.Core.Commands;

namespace post.cmd.api.Commands;

public class DeletePostCommand : BaseCommand
{
    public required string Username { get; set; }
}

