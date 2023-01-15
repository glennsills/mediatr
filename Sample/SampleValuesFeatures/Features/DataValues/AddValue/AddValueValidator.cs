using SampleValueFeatures.Features.DataValues.DataAccess;
using FluentValidation;

namespace SampleValueFeatures.Features.DataValues.AddValue;

public class AddValueValidator : AbstractValidator<AddValue>
{
    public AddValueValidator()
    {
        RuleFor(addValueModel => addValueModel).Must(MustNotExists).WithName("Key").WithMessage("That key is already in use");
    }

    public static bool MustNotExists(AddValue addValue)
    {
        return !DataContainer.ContainsKey(addValue.Key);
    }
}