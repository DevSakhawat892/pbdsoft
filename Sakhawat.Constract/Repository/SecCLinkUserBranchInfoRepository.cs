using Sakhawat.Constract.IRepository;
using Sakhawat.Data;
using Sakhawat.Model.Models;

namespace Sakhawat.Constract.Repository
{
  public class SecCLinkUserBranchInfoRepository : Repository<SecCLinkUserBranchInfo>, ISecCLinkUserBranchInfoRepository
  {
    private readonly ApplicationContext context;

    public SecCLinkUserBranchInfoRepository(ApplicationContext context) : base(context)
    {
      this.context = context;
    }
  }
}