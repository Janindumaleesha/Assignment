using BooksManagement.Models;

namespace BooksManagement.Interfaces
{
    public interface IBookService
    {
        Task<ResponseResult> Insert(ModelBookDetails _model);
        Task<ResponseResult> Update(Guid _bookId, ModelBookDetails _model);
        Task<ResponseResult> Delete(Guid _bookId);
        Task<ResponseResult> SelectAll();
        Task<ResponseResult> SelectById(Guid _bookId);
    }
}
