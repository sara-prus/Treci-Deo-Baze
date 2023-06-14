using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CudovistaLib;
using CudovistaLib.DTOs;
using System;

namespace Cudovista3.Controllers
{
    public class SpecijalneSposobnostiControllers
    {
        [Route("[controller]")]
        [ApiController]
        public class ProtivmereControllers : ControllerBase
        {
            [HttpGet]
            [Route("PreuzmiSpecijalneSposobnosti")]
            [ProducesResponseType(StatusCodes.Status400BadRequest)]
            public IActionResult GetSveSpecijalneSposobnosti()
            {
                try
                {
                    return new JsonResult(DataProvajderA.vratiSveSpecijalneSposobnosti());
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.ToString());
                }
            }

            [HttpGet]
            [Route("PreuzmiSpecijalnuSposobnost")]
            [ProducesResponseType(StatusCodes.Status400BadRequest)]
            public IActionResult GetSpecijalneSposobnost(int id)
            {
                try
                {
                    return new JsonResult(DataProvajderA.vratiSpecijalnuSposobnost(id));
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.ToString());
                }
            }

            [HttpPost]
            [Route("DodajSpecijalnuSposobnost/{idCudovista}")]
            [ProducesResponseType(StatusCodes.Status200OK)]
            [ProducesResponseType(StatusCodes.Status400BadRequest)]
            public IActionResult AddProtivmeru([FromRoute(Name = "idCudovista")] int idCudovista, [FromBody] Specijalne_sposobnostiView m)
            {
                try
                {

                    var cudoviste = DataProvajderS.VratiCudoviste(idCudovista);
                    m.Id_cudovista = cudoviste;
                    DataProvajderA.dodajSpecijalnuSposobnost(m);
                    return Ok("Uspesno ste dodali Specijalnu Sposobnost " + m.Spec_sposobnosti);
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.ToString());
                }
            }

            [HttpPut]
            [Route("PromeniSpecijalnuSposobnost/{idCudovista}")]
            [ProducesResponseType(StatusCodes.Status200OK)]
            [ProducesResponseType(StatusCodes.Status400BadRequest)]
            public IActionResult ChangeProtivmeru([FromRoute(Name = "idCudovista")] int idCudovista, [FromBody] Specijalne_sposobnostiView m)
            {
                try
                {
                    var cudoviste = DataProvajderS.VratiCudoviste(idCudovista);
                    m.Id_cudovista = cudoviste;
                    DataProvajderA.azurirajSpecijalnuSposobnost(m);
                    return Ok("Uspesno ste azurirali protivmeru  " + m.Spec_sposobnosti);
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.ToString());
                }
            }
            [HttpDelete]
            [Route("IzbrisiSpecijalnuSposobnost/{id}")]
            [ProducesResponseType(StatusCodes.Status200OK)]
            [ProducesResponseType(StatusCodes.Status400BadRequest)]
            public IActionResult DeleteProtivmeru(int id)
            {
                try
                {
                    DataProvajderA.obrisiSpecijalnuSposobnosti(id);
                    return Ok("Uspesno ste obrisali Specijalnu Sposobnost");
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.ToString());
                }
            }

        }
    }
}
