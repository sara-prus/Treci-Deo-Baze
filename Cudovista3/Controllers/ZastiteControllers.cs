using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CudovistaLib;
using CudovistaLib.DTOs;
using System;

namespace Cudovista3.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ZastitaControllers : ControllerBase
    {
        [HttpPut]
        [Route("DodajLokacijuZastiti/{idLokacije}/{idZastite}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddLocationProtection([FromRoute(Name = "idLokacije")] int idLokacije, [FromRoute(Name = "idZastite")] int idZastite)
        {
            try
            {
                // var cudoviste = DataProvajderS.VratiMagijskoCudoviste(cudovisteID);

                DataProvajderA.SacuvajZastituLokacija(idLokacije, idZastite);

                return Ok("uspesno ste dodali lokaciju zastiti");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }



        [HttpPost]
        [Route("DodajZastitu/{idLokacije}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddLokaciju([FromRoute(Name = "idLokacije")] int idLokacije, string zastita, [FromBody] ZastitaView p)
        {
            try
            {
                // var cudoviste = DataProvajderS.VratiMagijskoCudoviste(cudovisteID);

                DataProvajderA.DodajZastitu(p, idLokacije, zastita);

                return Ok("uspesno ste dodali zastitu");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("IzbrisiZastitu/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteLokaciju(int id)
        {
            try
            {
                DataProvajderA.obrisiZastitu(id);
                return Ok("Uspesno ste obrisali zastitu");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
