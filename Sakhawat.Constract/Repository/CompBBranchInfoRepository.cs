using Sakhawat.Constract.IRepository;
using Sakhawat.Data;
using Sakhawat.Model.Models;

namespace Sakhawat.Constract.Repository
{
  public class CompBBranchInfoRepository : Repository<CompBBranchInfo>, ICompBBranchInfoRepository
  {
    private readonly ApplicationContext context;

    public CompBBranchInfoRepository(ApplicationContext context) : base(context)
    {
      this.context = context;
    }


  }
}
