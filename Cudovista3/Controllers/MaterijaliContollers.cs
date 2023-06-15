using CudovistaLib.DTOs;
using CudovistaLib;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CudovistaLib.DTOs.TipMaterijala;

namespace Cudovista3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaterijaliContollers : ControllerBase
    {
        [HttpPut]
        [Route("DodajMaterijalPredmetu/{materijalID}/{predmetID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddMaterijal([FromRoute(Name = "materijalID" )] int materijalID, [FromRoute(Name = "predmetID")] int predmetID )
        {
            try
            {
                // var cudoviste = DataProvajderS.VratiMagijskoCudoviste(cudovisteID);

                DataProvajderS.SacuvajMaterijal(materijalID, predmetID);

                return Ok("uspesno ste dodali materijal premetu");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("DodajPredmetCudovistu/{predmetID}/{cudovisteID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddPredmet([FromRoute(Name = "predmetID")] int predmetID, [FromRoute(Name = "cudovisteID")] int cudovisteID)
        {
            try
            {
                

                DataProvajderS.SacuvajPredmet(predmetID, cudovisteID);

                return Ok("Uspesno ste dodeli predmetu cudoviste");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        
        //debagiracu ovu metodu da se doda predmet mada nisam sigurna da nam treba uopste al ok
        [HttpPost]
        [Route("DodajPredmet/{cudovisteID}/{materijal}/")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddPredmet([FromRoute(Name = "cudovisteID")] int cudovisteID, [FromRoute(Name = "materijal")] string materijal, [FromBody] PredmetView p)
        {
            try
            {
                // var cudoviste = DataProvajderS.VratiMagijskoCudoviste(cudovisteID);

                DataProvajderS.DodajPredmet(p, cudovisteID, materijal);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
