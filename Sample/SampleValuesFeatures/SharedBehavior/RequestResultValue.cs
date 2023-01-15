using FluentValidation.Results;

namespace SampleValuesFeatures.SharedBehavior;
public class RequestResultValue<T> : RequestResult
{
    public T? Result { get; set; }

    public static RequestResultValue<T> FromValidationResult(ValidationResult validationResult, T value)
    {
        return new RequestResultValue<T>()
        {
            Success = validationResult.IsValid,
            Errors = validationResult.Errors.Select(error => error.ErrorMessage).ToList(),
            Result = value
        };
    }
}
