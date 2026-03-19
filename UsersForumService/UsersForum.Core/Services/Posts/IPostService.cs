using entities = UsersForum.DAL.Entities;
using UsersForum.Core.Models;

namespace UsersForum.Core.Posts
{
    public interface IPostService
    {
        Task<IEnumerable<PostDto>> GetAllPosts();
        Task AddNewPostAsync(Models.Post post);
        Task DeletePostAsync(int postId);
        Task UpdatePostAsync(Models.Post post);
        Task<DAL.Entities.Post> GetPostById(int postId);


    }
}
