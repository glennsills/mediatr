using MediatR;

namespace FeatureLib.Features.DataValues.Get
{
    public class GetAllValues : IRequest<List<KeyValuePair<string, string>>>
    {
    }
}
