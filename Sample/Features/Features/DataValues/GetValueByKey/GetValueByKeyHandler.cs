using FeatureLib.Features.DataValues.DataAccess;
using MediatR;

namespace FeatureLib.Features.DataValues.GetValueByKey;

public class GetValueByKeyHandler : IRequestHandler<GetValueByKey, string>
{
    public async Task<string> Handle(GetValueByKey request, CancellationToken cancellationToken)
    {
        return await DataContainer.GetValueByKey(request.Key);
    }
}