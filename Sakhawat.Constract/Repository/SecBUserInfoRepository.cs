using Sakhawat.Constract.IRepository;
using Sakhawat.Data;
using Sakhawat.Model.Models;

namespace Sakhawat.Constract.Repository
{
  public class SecBUserInfoRepository : Repository<SecBUserInfo>, ISecBUserInfoRepository
  {
    private readonly ApplicationContext context;

    public SecBUserInfoRepository(ApplicationContext _context) : base(_context)
    {
      context = _context;
    }

    public void Update(SecBUserInfo entity)
    {
      dbSet.Update(entity);
    }
  }
}