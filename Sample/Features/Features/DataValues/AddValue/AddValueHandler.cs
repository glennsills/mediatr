using FeatureLib.Features.DataValues.DataAccess;
using MediatR;

namespace FeatureLib.Features.DataValues.AddValue
{
    public class AddValueHandler : IRequestHandler<AddValue>
    {
        public async Task<Unit> Handle(AddValue request, CancellationToken cancellationToken)
        {
            await DataContainer.Add(request.Key, request.Value);
            return Unit.Value;
        }
    }
}
