using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sakhawat.Constract.IRepository;
using Sakhawat.Model.Dtos;
using Sakhawat.Model.Models;

namespace Sakhawat.Controllers
{
   public class LoginController : Controller
   {
      private readonly IUnitOfWork context;

      public LoginController(IUnitOfWork context)
      {
         this.context = context;
      }

      // GET: LoginController
      public ActionResult Index()
      {
         return View();
      }

      //GET LOGIN
     [HttpGet]
      public IActionResult Dashboard()
      {
         IEnumerable<SecBUserInfo> userInfos = context.SecBUserInfo.GetAll();
         return View(userInfos);
      }

      // GET LOGIN
      [HttpPost]
      public JsonResult LoginUser(LoginDto model)
      {
         if (model != null)
         {
            SecBUserInfo userInfo = context.SecBUserInfo.GetFirstOrDefault(u => u.LoginNameEnglish.Trim().ToLower() == model.LoginNameEnglish.Trim().ToLower());
            if (userInfo == null)
            {
               return Json("true");
            }
            
            if (context.UserBranchInfo.GetFirstOrDefault(u => u.UserId == userInfo.UserId && u.BranchId == model.BranchId) != null)
            {
               return Json("true");
            }
         }
         return Json("true");
      }


      /// <summary>
      /// Get All Branches
      /// </summary>
      /// <returns></returns>
      [HttpGet]
      public IActionResult GetAllBranch()
      {
         IEnumerable<CompBBranchInfo> branchInfos = context.CompBBranchInfo.GetAll();
         return Json(branchInfos);
      }
   }
}
