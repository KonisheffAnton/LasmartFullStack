using Lasmart.Business.Models;

namespace Lasmart.Business.Interfaces
{
    public interface ICommentService : IDisposable
    {
        public Task DeleteCommentAsync(CommentBusinessModel CommentBusinessModel);

        public Task<IEnumerable<CommentBusinessModel>> GetAllCommentsAsync();
 
    }
}
