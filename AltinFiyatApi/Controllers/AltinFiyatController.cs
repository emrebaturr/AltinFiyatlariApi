using AltinFiyatApi.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AltinFiyatApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AltinFiyatController : ControllerBase
    {
        private readonly IAltinFiyatServisi _altinFiyatServisi;

        public AltinFiyatController(IAltinFiyatServisi altinFiyatServisi)
        {
            _altinFiyatServisi = altinFiyatServisi;
        }

        [HttpGet]
        public async Task<IActionResult> GetAltinFiyatlari()
        {
            var fiyatlar = await _altinFiyatServisi.AltinFiyatlariniGetirAsync();
            return Ok(fiyatlar);
        }
    }
}
