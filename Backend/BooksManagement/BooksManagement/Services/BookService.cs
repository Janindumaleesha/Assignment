using BooksManagement.Interfaces;
using BooksManagement.Models;

namespace BooksManagement.Services
{
    public class BookService : IBookService
    {
        private readonly List<ModelBookDetails> _book = new List<ModelBookDetails>();

        public async Task<ResponseResult> Insert(ModelBookDetails _model)
        {
            try
            {
                _model.Id = Guid.NewGuid();

                _book.Add(_model);

                return new ResponseResult(true, "Insert Successfully!");

            }
            catch (Exception ex)
            {
                return new ResponseResult(ex);
            }
        }

        public async Task<ResponseResult> Update(Guid _bookId, ModelBookDetails _model)
        {
            try
            {
                var book = _book.FirstOrDefault(x => x.Id == _bookId);

                if (book == null)
                {
                    return new ResponseResult("Record Not Found!");
                }

                book.Title = _model.Title;
                book.Author = _model.Author;
                book.ISBN = _model.ISBN;
                book.PublicationDate = _model.PublicationDate;

                return new ResponseResult(true, "Updated Successfully!");
            }
            catch (Exception ex)
            {
                return new ResponseResult(ex);
            }
        }

        public async Task<ResponseResult> Delete(Guid _bookId)
        {
            try
            {
                var book = _book.FirstOrDefault(x => x.Id == _bookId);

                if (book == null)
                {
                    return new ResponseResult("Record Not Found!");
                }

                _book.Remove(book);

                return new ResponseResult(true, "Deleted Successfully!");
            }
            catch (Exception ex)
            {
                return new ResponseResult(ex);
            }
        }

        public async Task<ResponseResult> SelectAll()
        {
            try
            {
                return new ResponseResult(true, "Success", _book);
            }
            catch (Exception ex)
            {
                return new ResponseResult(ex);
            }
        }

        public async Task<ResponseResult> SelectById(Guid _bookId)
        {
            try
            {
                var book = _book.FirstOrDefault(x => x.Id == _bookId);

                if (book == null)
                {
                    return new ResponseResult("Record Not Found!");
                }

                return new ResponseResult(true, "Success", book);
            }
            catch (Exception ex)
            {
                return new ResponseResult(ex);
            }
        }
    }
}
