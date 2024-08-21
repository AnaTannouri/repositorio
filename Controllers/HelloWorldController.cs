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
            // Gera uma temperatura aleat�ria entre 20�C e 40�C
            Random random = new Random();
            double temperature = random.Next(200, 401) / 10.0;

            // Verifica se a temperatura ultrapassa os 35�C
            if (temperature > 35.0)
            {
                return $"Alerta: Temperatura elevada! {temperature}�C";
            }
            else
            {
                return $"Temperatura normal: {temperature}�C";
            }
        }
    }
}
