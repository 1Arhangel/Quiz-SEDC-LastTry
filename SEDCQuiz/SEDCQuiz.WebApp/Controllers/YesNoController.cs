using SedcQuiz.Interfaces;
using SEDCQuiz.Domain.Entities;
using SEDCQuiz.Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SEDCQuiz.WebApp.Controllers
{
    public class YesNoController : Controller
    {
        private IYesNoRepository _yesNoRepo = new YesNoRepository();
        Random randomId = new Random();
        // GET: YesNo
        public ActionResult Index()
        {
            var yesNoes = _yesNoRepo.GetAll();

            return View(yesNoes);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(YesNo yesNo)
        {
            _yesNoRepo.Create(yesNo);
            return RedirectToAction("Index");
        }

        public ActionResult Play()
        {

            int nextQuestionId = randomId.Next(3, 10);

            YesNo question = _yesNoRepo.GetQuestionById(nextQuestionId);
            return View(question);
        }
        

        public ActionResult Answer(int id, string answer)
        {
            int nextQuestionId = randomId.Next(3, 10);
            int count = 0;
            YesNo question = _yesNoRepo.GetQuestionById(id);
            if (question.Answer == answer)
            {
                count += 2;
                YesNo newQuestion = _yesNoRepo.GetQuestionById(nextQuestionId);
                return RedirectToAction("Answer", new { YesNo = newQuestion });
            }
            YesNo newQuestion1 = _yesNoRepo.GetQuestionById(nextQuestionId);
            return RedirectToAction("Answer", new { YesNo = newQuestion1 });
        }
    }
}