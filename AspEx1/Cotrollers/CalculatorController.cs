using Microsoft.AspNetCore.Mvc;
using AspEx1.Models;

namespace AspEx1.Cotrollers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View(new CalculatorModel());
        }

        [HttpPost]
        public IActionResult Calculate(CalculatorModel model)
        {
            double result = 0;
            switch (model.Operator)
            {
                case "-":
                    {
                        result = model.X - model.Y;
                        break;
                    }
                case "+":
                    {
                        result = model.X + model.Y;
                        break;
                    }
                case "*":
                    {
                        result = model.X * model.Y;
                        break;
                    }
                case "/":
                    {
                        if (model.X < 0 && model.Y < 0)
                        {
                            ModelState.AddModelError("X OR Y", "Number must be bigger that 0");
                        }
                        else
                        {
                            result = model.X / model.Y;
                            break;
                        }
                        break;
                    }
            }
            model.Res = result;
            return View("Index", model);
        }

    }
}
