namespace _10Helmets.API.Core.DTOs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class ResponseDTO
    {
        /// <summary>
        /// 
        /// </summary>
        public bool IsCorrect { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public object Result { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="isCorrect"></param>
        /// <param name="message"></param>
        /// <param name="result"></param>
        public ResponseDTO(bool isCorrect,
            string message,
            object result)
        {
            this.IsCorrect = isCorrect;
            this.Message = message;
            this.Result = result;
        }
    }
}
