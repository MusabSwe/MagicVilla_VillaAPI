using MagicVilla_VillaAPI.Data;
using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Models.dto;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla_VillaAPI.Controllers
{
    [Route("api/VillaAPI")] // but not good practice be careful or  [Route("api/[controller]")]
    //[Route("api/[controller]")] will directly take the name of contoller
    // and put it in the url
    [ApiController]
    public class VillaAPIController : ControllerBase
    {
        // to log here we should use Dependency Injection
        // To create logging only need to create 
        // a constructor 
        private readonly ILogger<VillaAPIController> _logger;
        public VillaAPIController(ILogger<VillaAPIController> logger)
        {
            _logger = logger;
        }


        //Down we create the Endpoints
        //an endpoint is typically a uniform resource locator (URL)
        //that provides the location of a resource on the server.
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        // ActionResult used to return multiple types
        public ActionResult<IEnumerable<VillaDTO>> GetVillas()
        {
            _logger.LogInformation("Getting all villas");
            return Ok(VillaStore.VillaList);
        }

        // Add Name to the getById to use it when we post data and
        // redirect to the posted id
        [HttpGet("{id:int}", Name = "GetVilla")] // to specify the type of id {id:int} and show there is an input
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<VillaDTO> GetVilla(int id)
        {
            var villa = VillaStore.VillaList.FirstOrDefault(v => v.Id == id);
            if (id == 0)
            {
                _logger.LogError("Get Villa Error with Id: " + id);
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
            //To check if the name is unique
            if (VillaStore.VillaList.FirstOrDefault(v => v.Name.ToLower() == villaDTO.Name.ToLower()) != null)
            {
                ModelState.AddModelError("Unique", "Villa already exists!");
                return BadRequest(ModelState);
            }

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
            return CreatedAtRoute("GetVilla", new { id = villaDTO.Id }, villaDTO);
        }

        [HttpDelete("{id:int}", Name = "DeleteVilla")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult DeleteVilla(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var villa = VillaStore.VillaList.FirstOrDefault(v => v.Id == id);
            if (villa == null)
            {
                return NotFound();
            }
            VillaStore.VillaList.Remove(villa);
            return NoContent();
        }

        [HttpPut("{id:int}", Name = "UpdateVilla")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult UpdateVilla(int id, [FromBody] VillaDTO villaDTO)
        {

            if (villaDTO == null || id != villaDTO.Id)
            {
                return BadRequest();
            }
            var villa = VillaStore.VillaList.FirstOrDefault(v => v.Id == id);
            if (villa == null)
            {
                return NotFound();
            }
            villa.Name = villaDTO.Name;
            villa.Occupancy = villaDTO.Occupancy;
            villa.Sqft = villaDTO.Sqft;
            return NoContent();
        }

        [HttpPatch("{id:int}", Name = "UpdatePartialVilla")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult UpdatePartialVilla(int id, JsonPatchDocument<VillaDTO> patchDTO)
        {
            if (patchDTO == null || id == 0)
            {
                return BadRequest();
            }
            //find which villa wants to update
            var villa = VillaStore.VillaList.FirstOrDefault(v => v.Id == id);
            if (villa == null)
            {
                return NotFound();
            }
            // Apply partial update for the villa
            // checks the data annotation for VillaDTO class
            //so the down method first param --> for the updated villa
            // second param --> to checks data annotation such as [Required]
            patchDTO.ApplyTo(villa, ModelState);
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return NoContent();
        }
    }
}