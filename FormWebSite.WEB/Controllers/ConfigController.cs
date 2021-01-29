using FormWebSite.Bussiness.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormWebSite.WEB.Controllers
{
    public class ConfigController : Controller
    {
        private readonly IGenderService genderService;
        private readonly IStudyService studyService;
        private readonly IProgramService programService;

        public ConfigController(IGenderService genderService, IStudyService studyService, IProgramService programService)
        {
            this.genderService = genderService;
            this.studyService = studyService;
            this.programService = programService;
        }
        public IActionResult Index()
        {
            var genders = new string[] {"Erkek","Kadın"};
            genderService.AddRange(genders);

            var stduies = new string[] { "Lise", "Meslek Lİsesi","MYO/Ön Lisans", "Lisans", "Yüksek Lisans" };
            studyService.AddRange(stduies);

            var programs = new string[] { "Yok", "MS Office", "Özel Program" };
            programService.AddRange(programs);

            return View();
        }
    }
}
