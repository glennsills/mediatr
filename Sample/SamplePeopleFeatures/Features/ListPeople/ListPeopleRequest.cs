using MediatR;
using SampleSharedStuff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplePeopleFeatures.Features.ListPeople
{
    public class ListPeopleRequest: IRequest<RequestResultValue<List<PeopleListItem>>>
    {
    }
}
