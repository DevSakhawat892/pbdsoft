using Sakhawat.Model.Models;

namespace Sakhawat.Constract.IRepository
{
  public interface ISecBUserInfoRepository : IRepository<SecBUserInfo>
  {
    void Update(SecBUserInfo entity);
  }
}