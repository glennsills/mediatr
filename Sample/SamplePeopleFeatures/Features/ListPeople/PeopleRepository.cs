using Sample.Data;
using Sample.Data.Entities;
using SamplePeopleData;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplePeopleFeatures.Features.ListPeople;
public class PeopleRepository : BaseRepository
{
    public PeopleRepository(SamplePeopleDataContext context) : base(context)
    {
    }

    public virtual IEnumerable<Person> GetAllPeople()
    {
        return _context.People.ToList();
    }
}
