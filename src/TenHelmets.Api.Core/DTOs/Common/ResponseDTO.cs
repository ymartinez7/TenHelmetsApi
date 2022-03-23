namespace TenHelmets.API.Core.DTOs
{
    public sealed class ResponseDTO
    {
        public bool IsCorrect { get; set; }
        public string Message { get; set; }
        public object Result { get; set; }

        public ResponseDTO(bool isCorrect,
            string message,
            object result)
        {
            IsCorrect = isCorrect;
            Message = message;
            Result = result;
        }
    }
}
