using Lab2.Models;
using Microsoft.AspNetCore.Mvc;

/***
 * wyslanie żądania do form (potrzebna akcja w kontrolerze)
 * wypelnienie form i submit
 * wyslanie forma (potrzebna akcja ktora odb dane)
 * obliczenie i zwrocenie widoku z wynikami
**/



namespace Lab2.Controllers
{

    public enum Operators
    {
        ADD, SUB, MUL, DIV
    }


    public class CalcController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Result([FromForm] Calculator model)
        {
            if (!model.IsValid())
            {
                return View("Error");
            }
            return View(model);
        }


    }
}
