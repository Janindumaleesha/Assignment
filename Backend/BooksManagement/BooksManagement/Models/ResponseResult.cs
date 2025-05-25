namespace BooksManagement.Models
{
    public class ResponseResult
    {
        public bool IsSuccess { get; set; }
        public string? Message { get; set; }
        public object? Content { get; set; }

        public ResponseResult() { }

        public ResponseResult(bool _index, string? _message = null)
        {
            IsSuccess = _index == true ? true : false;
            Message = _message;
        }

        public ResponseResult(bool _index, string? _message, object? _content = null)
        {
            IsSuccess = _index == true ? true : false;
            Message = _message;
            Content = _content;
        }

        public ResponseResult(int _index)
        {
            IsSuccess = false;
            Message = _index switch
            {
                1 => "Something Went Wrong, Didn't Connect with the Database. Please Try Again",
                _ => "Something Went Wrong. Please Try Again"
            };
        }

        public ResponseResult(string? _message)
        {
            IsSuccess = false;
            Message = _message;
        }

        public ResponseResult(Exception _ex)
        {
            IsSuccess = false;
            Message = _ex.Message;
        }
    }
}
