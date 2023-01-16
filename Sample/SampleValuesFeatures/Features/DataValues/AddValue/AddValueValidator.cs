using SampleValueFeatures.Features.DataValues.DataAccess;
using FluentValidation;

namespace SampleValueFeatures.Features.DataValues.AddValue;

public class AddValueValidator : AbstractValidator<AddValue>
{
    public AddValueValidator()
    {
        RuleFor(x => x.Key).MinimumLength(3);
    }
}