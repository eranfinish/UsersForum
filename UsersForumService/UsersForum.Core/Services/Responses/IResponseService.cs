using UsersForum.DAL.Entities;

namespace UsersForum.Core.Responses
{
    public interface IResponseService
    {
        Task<IEnumerable<Response>> GetResponsesByPostId(int postId); ///
        Task AddResponse(Response response);
        Task UpdateResponse(Response response);
        Task DeleteResponse(int responseId);
        Task<Response?> GetResponseByIdAsync(int id);
    }
   
}
