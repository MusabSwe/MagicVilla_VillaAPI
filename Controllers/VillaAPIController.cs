using MagicVilla_VillaAPI.Data;
using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Models.dto;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla_VillaAPI.Controllers
{
    [Route("api/VillaAPI")] // but not good practice be careful or  [Route("api/[controller]")]
    //[Route("api/[controller]")] will directly take the name of contoller
    // and put it in the url
    [ApiController]
    public class VillaAPIController : ControllerBase
    {
        //Down we create the Endpoints
        //an endpoint is typically a uniform resource locator (URL)
        //that provides the location of a resource on the server.
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        // ActionResult used to return multiple types
        public ActionResult<IEnumerable<VillaDTO>> GetVillas()
        {
            return Ok(VillaStore.VillaList);
        }

        // Add Name to the getById to use it when we post data and
        // redirect to the posted id
        [HttpGet("{id:int}",Name ="GetVilla")] // to specify the type of id {id:int} and show there is an input
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<VillaDTO> GetVilla(int id)
        {
            var villa = VillaStore.VillaList.FirstOrDefault(v => v.Id == id);
            if (id == 0)
            {
                // response = 400
                return BadRequest();
            }
            if (villa == null)
            {
                // response = 404
                return NotFound();
            }
            return Ok(villa);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<VillaDTO> CreateVilla([FromBody] VillaDTO villaDTO)
        {
            // To check the state 
            //used to check for examle the Name is required
            // or to check name length data annoation for the model
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest();
            //}

            if (villaDTO == null)
            {
                return BadRequest();
            }
            //when we creating Vill the Id should be zero
            // no input for the ID
            if (villaDTO.Id > 0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            //to retrieve last ID in the list
            villaDTO.Id = VillaStore.VillaList.OrderByDescending(v => v.Id).FirstOrDefault().Id + 1;
            VillaStore.VillaList.Add(villaDTO);
            //Add route to the new posted value
            return CreatedAtRoute("GetVilla", new {id = villaDTO.Id}, villaDTO);
        }
    }
}