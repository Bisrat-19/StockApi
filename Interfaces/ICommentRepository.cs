using StockApi.Models;
using StockApi.Dtos.Comment;

namespace StockApi.Interfaces
{
    public interface ICommentRepository
    {
        Task<List<Comment>> GetAllAsync();
        Task<Comment?> GetByIdAsync(int id);
        Task<Comment> CreateAsync(Comment commentModel);
        Task<Comment?> UpdateAsync(int id, UpdateCommentRequestDto commentDto);
        Task<Comment?> DeleteAsync(int id);
    }
}
