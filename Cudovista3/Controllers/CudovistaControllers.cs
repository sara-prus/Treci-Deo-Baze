using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CudovistaLib;
using CudovistaLib.DTOs;
using System;

namespace Cudovista3.Controllers
{
   
    [Route("[controller]")]
    [ApiController]
    #region Magijska
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
        [HttpGet]
        [Route("PreuzmiMagijsko")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetMagijsko(int id)
        {
            try
            {
                return new JsonResult(DataProvajderS.VratiMagijskoCudoviste(id));
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
                return Ok("Uspesno ste dodali magijsko cudoviste "+m.Naziv_cudovista);
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
                return Ok("Uspesno ste azurirali magijsko cudoviste  "+m.Naziv_cudovista);
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
                return Ok("Uspesno ste obrisali magijsko cudoviste");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        #endregion
    #region Bajalice Kontroleri

        [HttpPost]
        [Route("DodajBajalicu/{cudovisteID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddBajalica([FromRoute(Name = "cudovisteID")] int cudovisteID, [FromBody] BajaliceView o)
        {
            try
            {
               // var cudoviste = DataProvajderS.VratiMagijskoCudoviste(cudovisteID);
                
                DataProvajderS.SacuvajBajalicu(o,cudovisteID);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        #endregion

    #region Nemagijska
        [HttpGet]
        [Route("PreuzmiNemagijska")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetSvaNemagijska()
        {
            try
            {
                return new JsonResult(DataProvajderS.VratiSvaNemagijska());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpGet]
        [Route("PreuzmiNemagijsko")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetNemagijsko(int id)
        {
            try
            {
                return new JsonResult(DataProvajderS.VratiNemagijskoCudoviste(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPost]
        [Route("DodajNemagijskoCudoviste")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddNemagijskoCudoviste([FromBody] NemagijskoView m)
        {
            try
            {
                DataProvajderS.DodajNemagijskoCudoviste(m);
                return Ok("Uspesno ste dodali nemagijsko cudoviste " + m.Naziv_cudovista);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("PromeniNemagijskoCudoviste")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ChangeNemagijskoCudoviste([FromBody] NemagijskoView m)
        {
            try
            {
                DataProvajderS.AzurirajNemagijskoCudoviste(m);
                return Ok("Uspesno ste promenili nemagijsko cudoviste"+ m.Naziv_cudovista);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpDelete]
        [Route("IzbrisiNemagijskoCudoviste/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteNemagijskoCudoviste(int id)
        {
            try
            {
                DataProvajderS.ObrisiNemagijskoCudoviste(id);
                return Ok("Uspesno ste orbisali nemagijsko cudoviste");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        #endregion
        #region Sposobnosti
        [HttpGet]
        [Route("PreuzmiSposobnosti/{cudovisteID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetSposobnosti(int cudovisteID)
        {
            try
            {
                return new JsonResult(DataProvajderS.VratiSposobnosti(cudovisteID));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
      
        [HttpPost]
        [Route("DodajSposobnostMagijsku/{cudovisteID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddSposobnost([FromRoute(Name = "cudovisteID")] int cudovisteID, [FromBody] MagijskeSposobnostiView o)
        {
            try
            {
                // var cudoviste = DataProvajderS.VratiMagijskoCudoviste(cudovisteID);

                DataProvajderS.SacuvajSposobnost(o, cudovisteID);

                return Ok("Uspesno ste dodali sposobnost "+o.Naziv_sposobnosti +"magijskom cudovistu");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        #endregion
    }
}
