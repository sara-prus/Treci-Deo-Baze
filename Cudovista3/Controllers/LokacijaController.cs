using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CudovistaLib;
using CudovistaLib.DTOs;
using System;

namespace Cudovista3.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LokacijaController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiLokacije")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetSveLokacije()
        {
            try
            {
                return new JsonResult(DataProvajderA.VratiSveLokacije());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiOstrvo")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetOstrvo(int id)
        {
            try
            {
                return new JsonResult(DataProvajderA.vratiOstrvo(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiPecinu")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetPecinu(int id)
        {
            try
            {
                return new JsonResult(DataProvajderA.vratiPecina(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiGradDuhova")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetGradDuhova(int id)
        {
            try
            {
                return new JsonResult(DataProvajderA.vratiGradDuhova(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        [HttpGet]
        [Route("PreuzmiPiramida")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetPiramida(int id)
        {
            try
            {
                return new JsonResult(DataProvajderA.vratiPiramidu(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiUkletiZamak")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetUkletiZamak(int id)
        {
            try
            {
                return new JsonResult(DataProvajderA.vratiUkletiZamak(id));
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
        public IActionResult AddLegendu([FromRoute(Name = "idCudovista")] int idCudovista, [FromBody] LegendeView m)
        {
            try
            {
                var cudoviste = DataProvajderS.VratiCudoviste(idCudovista);
                m.Id_cudovista = cudoviste;

                DataProvajderA.dodajLegendu(m);
                return Ok("Uspesno ste dodali Legendu " + m.Zemlja_porekla);
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

                var cudoviste = DataProvajderS.VratiCudoviste(idCudovista);
                m.Id_cudovista = cudoviste;


                DataProvajderA.azurirajLegendu(m);
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
