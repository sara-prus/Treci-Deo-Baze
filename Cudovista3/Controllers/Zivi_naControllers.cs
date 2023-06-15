using CudovistaLib;
using CudovistaLib.DTOs;
using CudovistaLib.Entiteti;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cudovista3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Zivi_naControllers : ControllerBase
    {
        [HttpPost]
        [Route("DodajZiviNa/{prestavnikID}/{lokacijaID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddBajalica([FromRoute(Name = "prestavnikID")] int prestavnikID, [FromRoute(Name = "lokacijaID")] int lokacijaID)
        {
            try
            {
                // var cudoviste = DataProvajderS.VratiMagijskoCudoviste(cudovisteID);
                DataProvajderS.SacuvajZiviNa( prestavnikID, lokacijaID);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
