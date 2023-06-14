using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CudovistaLib;
using CudovistaLib.DTOs;
using System;

namespace Cudovista3.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CudovistaControllers : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiMagijska")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetSvaMagijska()
        {
            try
            {
                return new JsonResult(DataProvajderS.VratiSvaMagijska());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajMagijskoCudoviste")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddMagijskoCudoviste([FromBody] MagijskoView m)
        {
            try
            {
                DataProvajderS.DodajMagijskoCudoviste(m);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("PromeniMagijskoCudoviste")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ChangeMagijskoCudoviste([FromBody] MagijskoView m)
        {
            try
            {
                DataProvajderS.AzurirajMagijskoCudoviste(m);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpDelete]
        [Route("IzbrisiMagijskoCudoviste/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteMagijskoCudoviste(int id)
        {
            try
            {
                DataProvajderS.ObrisiMagijskoCudoviste(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
