using FormHelper;
using FormWebSite.Bussiness.Abstract;
using FormWebSite.Entities.Concrete;
using FormWebSite.Entities.Concrete.IdentityLibraryEntities;
using FormWebSite.Entities.DTO.AppUserDTO;
using FormWebSite.WEB.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormWebSite.WEB.Controllers
{
    [AutoValidateAntiforgeryToken]
    public class FormController : Controller
    {
        private readonly IGenderService genderService;
        private readonly IMapperService mapperService;
        private readonly IStudyService studyService;
        private readonly IProgramService programService;
        private readonly UserManager<AppUser> userManager;
        private readonly IAppUserService appUserService;
        private readonly IUserEducationService userEducationService;
        private readonly IEducationService educationService;

        public FormController(IEducationService educationService,IGenderService genderService, IMapperService mapperService, IStudyService studyService, IProgramService programService, UserManager<AppUser> userManager, IUserEducationService userEducationService, IAppUserService appUserService)
        {
            this.genderService = genderService;
            this.mapperService = mapperService;
            this.studyService = studyService;
            this.programService = programService;
            this.userManager = userManager;
            this.userEducationService = userEducationService;
            this.appUserService = appUserService;
            this.educationService = educationService;
        }


        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var userName = User.Identity.Name;
            var user = await userManager.FindByNameAsync(userName);

            var userModel = mapperService.Mapper.Map<UserUpdateDto>(user);

            var genders = genderService.GetList();

            ViewBag.Genders = new SelectList(genders, "Id", "GenderName");

            var studies = studyService.GetList();

            ViewBag.Studies = studies;

            var programs = programService.GetList();
            ViewBag.Programs = new SelectList(programs, "Id", "ProgramCat");

            return View(userModel);
        }

        [HttpPost]
        [FormValidator]
        public async Task<IActionResult> Index(UserUpdateDto model)
        {
            var userName = User.Identity.Name;
            var user = await userManager.FindByNameAsync(userName);

            user.GenderId = model.GenderId;
            user.aydin = model.aydin;
            user.Birthday = model.BirthDay;
            user.Book = model.Book;
            user.ClassroomTrainings = model.ClassroomTrainings;
            user.Master = model.Master;
            user.OnTheJob = model.OnTheJob;
            user.Other = model.Other;
            user.OtherExplanation = model.OtherExplanation;
            user.ProgramId = model.ProgramId;
            user.ProgramName = model.ProgramName;
            user.riza = model.riza;
            
            await userManager.UpdateAsync(user);
            return FormResult.CreateSuccessResult("User saved. Please wait...", Url.Action("Index", "Form"));
        }

        [HttpGet]
        public async Task<JsonResult> AddUserEducation(int studyId,string schoolName,string departmentName)
        {
            var userName = User.Identity.Name;
            var user = await userManager.FindByNameAsync(userName);

            userEducationService.Add(user,studyId,schoolName,departmentName);


            return Json("200");
        }

        [HttpGet]
        public async Task<JsonResult> GetEducations()
        {
            var userName = User.Identity.Name;
            var user = await userManager.FindByNameAsync(userName);

            var educations = appUserService.GetUserEducations(user.Id);

            var myEdu = new List<EducationModel>();
            foreach (var item in educations)
            {
                myEdu.Add(new EducationModel
                {
                    Id=item.EducationsId,
                    DepartmentName=item.Education.DepartmentName,
                    SchoolName=item.Education.SchoolName,
                    StudyName=item.Education.Study.StudyName
                });
            }
            return Json(myEdu);
        }

        [HttpGet]
        public JsonResult DeleteEducation(int id)
        {
            var edu = educationService.Get(i=>i.Id==id);
            educationService.Delete(edu);
            return Json("200");
        }

    }
}
