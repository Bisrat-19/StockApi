using StockApi.Models;
using StockApi.Dtos.Comment;

namespace StockApi.Mappers
{
    public static class CommentMapper
    {
        public static CommentDto ToCommentDto(this Comment commentModel)
        {
            return new CommentDto
            {
                Id = commentModel.Id,
                Title = commentModel.Title,
                Content = commentModel.Content,
                CreatedAt = commentModel.CreatedAt,
                StockId = commentModel.StockId
            };
        }

        public static Comment ToCommentFromCreateDTO(this CreateCommentRequestDto commentDto, int stockId)
        {
            return new Comment
            {
                Title = commentDto.Title,
                Content = commentDto.Content,
                StockId = stockId
            };
        }

        public static Comment ToCommentFromUpdateDTO(this UpdateCommentRequestDto updateDto, Comment comment)
        {
            comment.Title = updateDto.Title;
            comment.Content = updateDto.Content;
            return comment;
        }
    }
}