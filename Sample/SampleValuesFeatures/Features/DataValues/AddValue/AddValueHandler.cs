using SampleValueFeatures.Features.DataValues.DataAccess;
using MediatR;
using FluentValidation.Results;
using SampleSharedStuff;

namespace SampleValueFeatures.Features.DataValues.AddValue;

public class AddValueHandler : IRequestHandler<AddValue, RequestResult>
{
    public async Task<RequestResult> Handle(AddValue request, CancellationToken cancellationToken)
    {
        var addDataValidator = new AddValueValidator();
        ValidationResult validationResult = addDataValidator.Validate(request);

        if (validationResult.IsValid)
        {
            await DataContainer.Add(request.Key, request.Value);
        }

        return RequestResult.FromValidationResult(validationResult);
    }
}