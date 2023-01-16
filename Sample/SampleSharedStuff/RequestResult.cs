using FluentValidation.Results;

namespace SampleSharedStuff;

public class RequestResult
{
    public List<string> Errors { get; set; } = new List<string>();
    public bool Success { get; set; }
    public static RequestResult FromValidationResult(ValidationResult validationResult)
    {
        return new RequestResult()
        {
            Success = validationResult.IsValid,
            Errors = validationResult.Errors.Select(error => error.ErrorMessage).ToList(),
        };
    }
}