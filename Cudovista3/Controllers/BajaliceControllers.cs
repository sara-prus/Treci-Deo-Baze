using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CudovistaLib;
using CudovistaLib.DTOs;
using System;


namespace Cudovista3.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BajaliceControllers : ControllerBase
    {


        [HttpPost]
        [Route("DodajBajalicu/{cudovisteID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddBajalica([FromRoute(Name = "cudovisteID")] int cudovisteID, [FromBody] BajaliceView o)
        {
            try
            {
                // var cudoviste = DataProvajderS.VratiMagijskoCudoviste(cudovisteID);

                DataProvajderS.SacuvajBajalicu(o, cudovisteID);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

    }
}
