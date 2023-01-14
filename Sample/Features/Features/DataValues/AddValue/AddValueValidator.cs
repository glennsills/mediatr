using FeatureLib.Features.DataValues.DataAccess;
using FluentValidation;

namespace FeatureLib.Features.DataValues.AddValue
{
    public class AddValueValidator : AbstractValidator<AddValue>
    {
        public AddValueValidator()
        {
            RuleFor(addValueModel => addValueModel).MustAsync(MustNotExists).WithMessage("That key is already in use");
        }

        public async Task<bool> MustNotExists(AddValue addValue, CancellationToken cancellationToken)
        {
            return !await DataContainer.ContainsKey(addValue.Key);
        }
    }
}
