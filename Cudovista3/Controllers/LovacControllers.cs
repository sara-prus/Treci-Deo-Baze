using CudovistaLib.DTOs;
using CudovistaLib;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace Cudovista3.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LovacControllers : ControllerBase
    {

        
            [HttpGet]
            [Route("PreuzmiLovce")]
            [ProducesResponseType(StatusCodes.Status400BadRequest)]
            public IActionResult GetSveLovce()
            {
                try
                {
                    return new JsonResult(DataProvajderA.vratiSveLovce());
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.ToString());
                }
            }

            [HttpGet]
            [Route("PreuzmiLovca")]
            [ProducesResponseType(StatusCodes.Status400BadRequest)]
            public IActionResult GetLovca(int id)
            {
                try
                {
                    return new JsonResult(DataProvajderA.vratiLovca(id));
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.ToString());
                }
            }

            [HttpPost]
            [Route("DodajLovca/{idPredstavnika}")]
            [ProducesResponseType(StatusCodes.Status200OK)]
            [ProducesResponseType(StatusCodes.Status400BadRequest)]
            public IActionResult AddLovca([FromRoute(Name = "idPredstavnika")] int idPredstavnika, [FromBody] LovacView m)
            {
                try
                {

                    DataProvajderA.dodajLovca(m, idPredstavnika);
                    return Ok("Uspesno ste dodali lovca");
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.ToString());
                }
            }

            [HttpPut]
            [Route("PromeniLovca/{idPredstavnika}")]
            [ProducesResponseType(StatusCodes.Status200OK)]
            [ProducesResponseType(StatusCodes.Status400BadRequest)]
            public IActionResult ChangeLovca([FromRoute(Name = "idPredstavnika")] int idPredstavnika, [FromBody] LovacView m)
            {
                try
                {
                    DataProvajderA.azurirajLovca(m, idPredstavnika);
                    return Ok("Uspesno ste azurirali lovca");
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.ToString());
                }
            }
            [HttpDelete]
            [Route("IzbrisiLovca/{id}")]
            [ProducesResponseType(StatusCodes.Status200OK)]
            [ProducesResponseType(StatusCodes.Status400BadRequest)]
            public IActionResult DeleteLovca(int id)
            {
                try
                {
                    DataProvajderA.obrisiLovca(id);
                    return Ok("Uspesno ste obrisali lovca");
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.ToString());
                }
            }

        
    }
}
