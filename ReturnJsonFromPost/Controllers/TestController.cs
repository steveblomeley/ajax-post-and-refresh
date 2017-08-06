using System.Collections.Generic;
using System.Web.Mvc;
using ReturnJsonFromPost.Models;

namespace ReturnJsonFromPost.Controllers
{
    public class TestController : Controller
    {
        private static readonly HashSet<MyModel> Data = new HashSet<MyModel>
        {
            new MyModel {Id = 1, Data = "One"},
            new MyModel {Id = 2, Data = "Two"}
        };


        public ViewResult Index()
        {
            var model = new MyViewModel
            {
                ErrorMessage = string.Empty,
                Models = Data
            };

            return View(model);
        }

        public PartialViewResult ListOfModels(MyViewModel model)
        {

            return PartialView("_ListOfModels", model);
        }

        [HttpPost]
        public PartialViewResult Create(MyModel model, int someParam)
        {
            Data.Add(model);

            var viewModel = new MyViewModel
            {
                ErrorMessage = $"Just saved {model.Data} with some param = {someParam}",
                Models = Data
            };

            return PartialView("_ListOfModels", viewModel);
        }
    }
}