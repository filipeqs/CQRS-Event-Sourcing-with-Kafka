using cqrs.core.Events;

namespace Post.Common.Events;

internal class PostRemovedEvent : BaseEvent
{
    public PostRemovedEvent() : base(nameof(PostRemovedEvent))
    {
    }
}
