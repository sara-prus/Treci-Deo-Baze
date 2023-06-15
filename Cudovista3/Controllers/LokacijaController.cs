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
        [HttpPut]
        [Route("DodajZastituLokaciji/{idLokacije}/{idZastite}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddLocationProtection([FromRoute(Name = "idLokacije")] int idLokacije, [FromRoute(Name = "idZastite")] int idZastite)
        {
            try
            {
                // var cudoviste = DataProvajderS.VratiMagijskoCudoviste(cudovisteID);

                DataProvajderA.SacuvajLokacijuZastita(idLokacije, idZastite);

                return Ok("uspesno ste dodali materijal premetu");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("DodajBorbuLokaciji/{idLokacije}/{idPredstavnika}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddLocationFight([FromRoute(Name = "idLokacije")] int idLokacije, [FromRoute(Name = "idPredstavnika")] int idPredstavnika)
        {
            try
            {
                // var cudoviste = DataProvajderS.VratiMagijskoCudoviste(cudovisteID);

                DataProvajderA.SacuvajLokacijuBorba(idLokacije, idPredstavnika);

                return Ok("uspesno ste dodali materijal premetu");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("DodajPredstavnikaLokaciji/{idLokacije}/{idPredstavnika}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddLocationMember([FromRoute(Name = "idLokacije")] int idLokacije, [FromRoute(Name = "idPredstavnika")] int idPredstavnika)
        {
            try
            {
                // var cudoviste = DataProvajderS.VratiMagijskoCudoviste(cudovisteID);

                DataProvajderA.SacuvajLokacijuPredstavnikZivi(idLokacije, idPredstavnika);

                return Ok("uspesno ste dodali materijal premetu");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

    }
}
