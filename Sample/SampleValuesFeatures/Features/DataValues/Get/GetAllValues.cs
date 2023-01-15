using MediatR;

namespace SampleValueFeatures.Features.DataValues.Get;

public class GetAllValues : IRequest<List<KeyValuePair<string, string>>>
{
}