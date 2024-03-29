﻿using SampleValueFeatures.Features.DataValues.DataAccess;
using MediatR;

namespace SampleValueFeatures.Features.DataValues.Get;

public class GetAllDataHandler : IRequestHandler<GetAllValues, List<KeyValuePair<string, string>>>
{
    public async Task<List<KeyValuePair<string, string>>> Handle(GetAllValues request, CancellationToken cancellationToken)
    {
        throw new ArgumentNullException(nameof(request));
        return await DataContainer.GetAllData();
    }
}