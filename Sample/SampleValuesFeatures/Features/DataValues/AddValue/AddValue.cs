using MediatR;
using SampleSharedStuff;

namespace SampleValueFeatures.Features.DataValues.AddValue;

public class AddValue : IRequest<RequestResult>
{
    public string Key { get; set; } = string.Empty;
    public string Value { get; set; } = string.Empty;
}