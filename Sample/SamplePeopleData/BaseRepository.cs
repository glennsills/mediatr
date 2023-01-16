using Sample.Data;
using SampleSharedStuff;

namespace SamplePeopleData;
public class BaseRepository
{
    protected readonly SamplePeopleDataContext _context;

    public BaseRepository(SamplePeopleDataContext context) { _context = context; }

    public virtual RequestResult CommitChanges() { return new RequestResult { Success = false }; }
}
