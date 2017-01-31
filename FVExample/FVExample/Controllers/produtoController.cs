using System.Web.Mvc;
using FVExample.ViewModels;
using FVExample.ViewModelValidators;

namespace FVExample.Controllers
{
    public class ProdutoController : Controller
    {
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(ProdutoVM model)
        {

            var validationResult = new ProdutoVMValidator().Validate(model);

            foreach (var error in validationResult.Errors)
                ModelState.AddModelError(error.PropertyName, error.ErrorMessage);

            if (ModelState.IsValid)
            {
                return View(model);
            }
            return View(model);
        }

        //[HttpPost]
        //public ActionResult CreateSpecific(ProdutoVM model)
        //{

        //    var validationResult = new ProdutoVMValidator().Validate(model);

        //    if (validationResult.IsValid)
        //    {
        //        //Faz alguma coisa...
        //        return RedirectToAction("Index", "Home");
        //    }
        //    return View(model);
        //}
    }
}