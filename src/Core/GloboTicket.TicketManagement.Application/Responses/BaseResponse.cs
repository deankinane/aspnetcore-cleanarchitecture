namespace GloboTicket.TicketManagement.Application.Responses
{
    public class BaseResponse
    {
        public BaseResponse()
        {
            Success = true;
        }
        public BaseResponse(string message)
        {
            Success = true;
            Message = message;
        }

        public BaseResponse(string message, bool success)
        {
            Success = success;
            Message = message;
        }

        public void FromValidator(List<FluentValidation.Results.ValidationFailure> validationErrors)
        {
            ValidationErrors = validationErrors.Select(e => e.ErrorMessage).ToList();
            Success = ValidationErrors.Count == 0;
        }

        public bool Success { get; set; }
        public string Message { get; set; } = string.Empty;
        public List<string>? ValidationErrors { get; set; }
    }
}
