namespace Auth_Service.Models.DTOs
{
    public class UniformResponsesDto
    {
        public string ErrorMessage { get; set; } = string.Empty;

        public object Result { get; set; } = default!;
        public bool isSuccess { get; set;} = true;
    }
}
