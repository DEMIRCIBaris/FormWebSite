using FormWebSite.Bussiness.Abstract;
using FormWebSite.Entities.Concrete.IdentityLibraryEntities;
using FormWebSite.Entities.DTO.AppUserDTO;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FormWebSite.WEB.Controllers
{
    [AutoValidateAntiforgeryToken]
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly IMapperService mapperService;
        private readonly SignInManager<AppUser> signInManager;

        public AccountController(UserManager<AppUser> userManager, IMapperService mapperService, SignInManager<AppUser> signInManager)
        {
            this.userManager = userManager;
            this.mapperService = mapperService;
            this.signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LogIn(UserSignInDto model)
        {
            var user = await userManager.FindByNameAsync(model.UserName);
            if (user != null)
            {
                var result = await signInManager.PasswordSignInAsync(user.UserName, model.Password, model.RememberMe, false);
                return RedirectToAction("Index", "Home"); //sayfa yönlendirme
            }
            else
            {
                ModelState.AddModelError("", " Kullanıcı adı veya şifre bulunumadı.");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(UserAddDto model)
        {
            var user = mapperService.Mapper.Map<AppUser>(model);
            var result = await userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                return RedirectToAction("LogIn");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
            }
            return View(model);
        }
        public async Task<IActionResult> LogOut()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("LogIn");
        }
        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
