using CudovistaLib.DTOs;
using CudovistaLib;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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

        [HttpPost]
        [Route("DodajPredmet/{cudovisteID}/{materijal}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddPredmet(int cudovisteID, string materijal, [FromBody] PredmetView p)
        {
            try
            {
                DataProvajderS.DodajPredmet(p, cudovisteID, materijal);

                return Ok("Uspesno ste dodali predmet " + p.Tip_Predmeta);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception)
            {
                return BadRequest("Doslo je do greske prilikom dodavanja predmeta.");
            }
        }

        [HttpDelete]
        [Route("IzbrisiPredmet/{predmetID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeletePredmet(int predmetID)
        {
            try
            {
                DataProvajderS.DeletePredmet(predmetID);

                return Ok("Predmet successfully deleted.");
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception)
            {
                return BadRequest("An error occurred while deleting the predmet.");
            }
        }


    }
}
