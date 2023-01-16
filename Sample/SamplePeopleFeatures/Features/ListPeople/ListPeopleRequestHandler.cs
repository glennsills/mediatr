using MediatR;
using SampleSharedStuff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplePeopleFeatures.Features.ListPeople;
public class ListPeopleRequestHandler : IRequestHandler<ListPeopleRequest, RequestResultValue<List<PeopleListItem>>>
{
    public Task<RequestResultValue<List<PeopleListItem>>> Handle(ListPeopleRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
