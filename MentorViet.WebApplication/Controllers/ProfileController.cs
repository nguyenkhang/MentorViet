using System.Web.Mvc;
using MentorViet.Contract;

namespace MentorViet.WebApplication.Controllers
{
    public class ProfileController : Controller
    {
        private readonly IUserProfileService _userProfileService;

        public ProfileController(IUserProfileService userProfileService)
        {
            _userProfileService = userProfileService;
        }

        public ActionResult Index()
        {
            var userProfile = _userProfileService.GetUserProfile("");
            return View();
        }
    }
}