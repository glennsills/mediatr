using MediatR;

namespace FeatureLib.Features.DataValues.GetValueByKey
{
    public class GetValueByKey : IRequest<string>
    {
        public string Key { get; set; } = string.Empty;
    }
}
