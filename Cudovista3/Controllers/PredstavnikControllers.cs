﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CudovistaLib;
using CudovistaLib.DTOs;
using System;

namespace Cudovista3.Controllers
{

    [Route("[controller]")]
    [ApiController]
    public class PredstavnikControllers : ControllerBase
    {
      
        
            [HttpGet]
            [Route("PreuzmiPredstavnike")]
            [ProducesResponseType(StatusCodes.Status400BadRequest)]
            public IActionResult GetSvePredstavnike()
            {
                try
                {
                    return new JsonResult(DataProvajderA.vratiSvePredstavnike());
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.ToString());
                }
            }

            [HttpGet]
            [Route("PreuzmiPredstavnika")]
            [ProducesResponseType(StatusCodes.Status400BadRequest)]
            public IActionResult GetPredstavnika(int idPredstavnika)
            {
                try
                {
                    return new JsonResult(DataProvajderA.VratiPredstavnika(idPredstavnika));
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.ToString());
                }
            }

            [HttpPost]
            [Route("DodajPredstavnika/{idCudovista}/{idLokacije}")]
            [ProducesResponseType(StatusCodes.Status200OK)]
            [ProducesResponseType(StatusCodes.Status400BadRequest)]
            public IActionResult AddPredstavnika([FromRoute(Name = "idCudovista")] int idCudovista, [FromRoute(Name = "idLokacije")] int idLokacije, [FromBody] PredstavnikView m)
            {
                try
                {

                    DataProvajderA.dodajPredstavnika(m, idCudovista, idLokacije);
                    return Ok("Uspesno ste dodali predstavnika ");
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.ToString());
                }
            }

            [HttpPut]
            [Route("PromeniPredstavnika")]
            [ProducesResponseType(StatusCodes.Status200OK)]
            [ProducesResponseType(StatusCodes.Status400BadRequest)]
            public IActionResult ChangePredstavnika([FromBody] PredstavnikView m)
            {
                try
                {

                    DataProvajderA.azurirajPredstavnika(m);
                    return Ok("Uspesno ste azurirali predstavnika");
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.ToString());
                }
            }
            [HttpDelete]
            [Route("IzbrisiPredstavnka/{id}")]
            [ProducesResponseType(StatusCodes.Status200OK)]
            [ProducesResponseType(StatusCodes.Status400BadRequest)]
            public IActionResult DeletePredstavnika(int id)
            {
                try
                {
                    DataProvajderA.obrisiPredstavnika(id);
                    return Ok("Uspesno ste obrisali predstavnika");
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.ToString());
                }
            }
        
    }
}
