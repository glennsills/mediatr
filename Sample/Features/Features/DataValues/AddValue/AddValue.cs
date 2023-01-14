using MediatR;

namespace FeatureLib.Features.DataValues.AddValue;

public class AddValue : IRequest
{
    public string Key { get; set; } = string.Empty;
    public string Value { get; set; } = string.Empty;
}