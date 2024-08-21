using Microsoft.AspNetCore.Mvc;

namespace HelloWorldWebService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TemperatureController : ControllerBase
    {
        // GET: api/temperature
        [HttpGet]
        public ActionResult<string> GetTemperature()
        {
            // Gera uma temperatura aleatória entre 20ºC e 40ºC
            Random random = new Random();
            double temperature = random.Next(200, 401) / 10.0;

            // Verifica se a temperatura ultrapassa os 35ºC
            if (temperature > 35.0)
            {
                return $"Alerta: Temperatura elevada! {temperature}ºC";
            }
            else
            {
                return $"Temperatura normal: {temperature}ºC";
            }
        }
    }
}
