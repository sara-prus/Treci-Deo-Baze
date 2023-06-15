using CudovistaLib;
using CudovistaLib.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace Cudovista3.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LegendeControllers : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiLegende")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetSveLegende()
        {
            try
            {
                return new JsonResult(DataProvajderA.vratiSvaLegende());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiLegendu")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetLegendu(int id)
        {
            try
            {
                return new JsonResult(DataProvajderA.vratiLegendu(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajLegendu/{idCudovista}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddLegendu([FromRoute(Name ="idCudovista")] int idCudovista, [FromBody] LegendeView m)
        {
            try
            {

                DataProvajderA.dodajLegendu(m, idCudovista);
                return Ok("Uspesno ste dodali Legendu " + m.Tekst);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("PromeniLegendu/{idCudovista}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ChangeLegendu([FromRoute(Name = "idCudovista")] int idCudovista, [FromBody] LegendeView m)
        {
            try
            {


                DataProvajderA.azurirajLegendu(m, idCudovista);
                return Ok("Uspesno ste azurirali Legendu  " + m.Zemlja_porekla);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpDelete]
        [Route("IzbrisiLegendu/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteLegendu(int id)
        {
            try
            {
                DataProvajderA.obrisiLegendu(id);
                return Ok("Uspesno ste obrisali legendu");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
