﻿using FeatureLib.Features.DataValues.DataAccess;
using MediatR;

namespace FeatureLib.Features.DataValues.Get
{
    public class GetAllDataHandler : IRequestHandler<GetAllValues, List<KeyValuePair<string, string>>>
    {
        public async Task<List<KeyValuePair<string, string>>> Handle(GetAllValues request, CancellationToken cancellationToken)
        {
            return await DataContainer.GetAllData();
        }
    }
}
