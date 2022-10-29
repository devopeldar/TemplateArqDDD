using FluentValidation.Results;

namespace TemplateArqDDD.Transversal.Common
{
    public class Response<T>
    {
        public T? Data { get; set; }
        public bool IsSuccess { get; set; }
        public string Message { get; set; } = String.Empty;
        public IEnumerable<ValidationFailure>? Errors { get; set; }
    }
    public interface IApi
    {
        public string GET(string url);
        public string POST(string url, string body);
    }
}
