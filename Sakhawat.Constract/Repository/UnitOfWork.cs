using Sakhawat.Constract.IRepository;
using Sakhawat.Data;

namespace Sakhawat.Constract.Repository
{
  public class UnitOfWork : IUnitOfWork
  {
    private readonly ApplicationContext context;

    public UnitOfWork(ApplicationContext context)
    {
      this.context = context;
      SecBUserInfo = new SecBUserInfoRepository(context);
      CompBBranchInfo = new CompBBranchInfoRepository(context);
      UserBranchInfo = new SecCLinkUserBranchInfoRepository(context);
    }

    public void Save()
    {
      context.SaveChanges();
    }

    public ISecBUserInfoRepository SecBUserInfo { get; private set; }
    public ICompBBranchInfoRepository CompBBranchInfo { get; private set; }
    public ISecCLinkUserBranchInfoRepository UserBranchInfo { get; private set; }

  }
}
