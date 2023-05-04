namespace Sakhawat.Constract.IRepository
{
  public interface IUnitOfWork
  {
    ISecBUserInfoRepository SecBUserInfo { get; }
    ICompBBranchInfoRepository CompBBranchInfo { get; }
    ISecCLinkUserBranchInfoRepository UserBranchInfo { get; }

    void Save();
  }
}