using MediatR;

namespace MW.KUNTUR.Blog.Application.UseCases.Commands.CreatePost;

public record CreatePostCommandHandler : IRequestHandler<CreatePostCommand, int>
{
    public Task<int> Handle(CreatePostCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}