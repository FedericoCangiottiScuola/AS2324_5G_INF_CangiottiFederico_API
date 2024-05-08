using Microsoft.AspNetCore.Mvc;

namespace AS2324_5G_INF_CangiottiFederico_API.Controllers
{
    public class MathController : Controller
    {
        [HttpGet("MultiploIntero")]

        public JsonResult MultiploIntero(int firstNumber, int secondNumber)
        {
            string output = string.Empty;
            string status = string.Empty;
            string messagge = string.Empty;


            if (firstNumber % secondNumber == 0)
            {
                output = "true";
                status = "OK";
                messagge = "The first number is multiple of the second number";
            }

            return new JsonResult(new
            {
                output = output,
                status = status,
                messagge = messagge
            });
        }

        [HttpGet("Potenza")]

        public JsonResult Potenza(int b, int esponente)
        {
            string output = string.Empty;
            string status = string.Empty;
            string messagge = string.Empty;

            return new JsonResult(new
            {
                output = Math.Pow(b, esponente),
                status = status,
                messagge = messagge
            });
        }
    }
}
