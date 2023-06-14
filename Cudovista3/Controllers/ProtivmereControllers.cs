using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CudovistaLib;
using CudovistaLib.DTOs;
using System;

namespace Cudovista3.Controllers

{


        [Route("[controller]")]
        [ApiController]
        public class ProtivmereControllers : ControllerBase
        {
            [HttpGet]
            [Route("PreuzmiProtivmere")]
            [ProducesResponseType(StatusCodes.Status400BadRequest)]
            public IActionResult GetSveProtivmere()
            {
                try
                {
                    return new JsonResult(DataProvajderA.vratiSveProtivmere());
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.ToString());
                }
            }

            [HttpGet]
            [Route("PreuzmiProtivmeru")]
            [ProducesResponseType(StatusCodes.Status400BadRequest)]
            public IActionResult GetProtivmeru(int id)
            {
                try
                {
                    return new JsonResult(DataProvajderA.vratiProtivmeru(id));
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.ToString());
                }
            }

            [HttpPost]
            [Route("DodajProtivmeru")]
            [ProducesResponseType(StatusCodes.Status200OK)]
            [ProducesResponseType(StatusCodes.Status400BadRequest)]
            public IActionResult AddProtivmeru([FromBody] ProtivmereView m)
            {
                try
                {
                    DataProvajderA.dodajProtivmeru(m);
                    return Ok("Uspesno ste dodali protivmeru " + m.Naziv_protivmere);
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.ToString());
                }
            }

            [HttpPut]
            [Route("PromeniProtivmeru")]
            [ProducesResponseType(StatusCodes.Status200OK)]
            [ProducesResponseType(StatusCodes.Status400BadRequest)]
            public IActionResult ChangeProtivmeru([FromBody] ProtivmereView m)
            {
                try
                {
                    DataProvajderA.azurirajProtivmeru(m);
                    return Ok("Uspesno ste azurirali protivmeru  " + m.Naziv_protivmere);
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.ToString());
                }
            }
            [HttpDelete]
            [Route("IzbrisiProtivmeru/{id}")]
            [ProducesResponseType(StatusCodes.Status200OK)]
            [ProducesResponseType(StatusCodes.Status400BadRequest)]
            public IActionResult DeleteProtivmeru(int id)
            {
                try
                {
                    DataProvajderA.obrisiProtivmeru(id);
                    return Ok("Uspesno ste obrisali protivmeru");
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.ToString());
                }
            }

        }
 }

