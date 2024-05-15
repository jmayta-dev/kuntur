using MediatR;
using MW.KUNTUR.Blog.Application.DTOs;

namespace MW.KUNTUR.Blog.Application.UseCases.Commands.CreatePost;

public record CreatePostCommand : CreatePostDTO, IRequest<int>
{

}