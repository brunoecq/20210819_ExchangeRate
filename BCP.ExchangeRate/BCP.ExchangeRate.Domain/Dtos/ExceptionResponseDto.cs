

namespace BCP.ExchangeRate.Domain.Dtos

{
    public class ExceptionResponseDto
    {
        public string Message { get; set; }
        public string StackTrace { get; set; }
        public ExceptionResponseDto(string message = null, string stackTrace = null)
        {
            Message = message;
            StackTrace = stackTrace;
        }
    }
}
