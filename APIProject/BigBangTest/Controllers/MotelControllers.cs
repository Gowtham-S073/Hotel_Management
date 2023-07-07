using BigBangTest.Auth;
using BigBangTest.Models;
using BigBangTest.Services.MotelServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BigBangTest.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MotelControllers : ControllerBase
    {
        private readonly IMotelServices _context;

        public MotelControllers(IMotelServices context)
        {
            _context = context;
        }


        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<List<Motel>>> GetMotelDetails()
        {
            try
            {
                return await _context.GetMotelDetails();
            }
            catch (Exception)
            {
                return StatusCode(500, "Internal Server Error");
            }
        }

        [HttpPost]
        public async Task<ActionResult<Motel>> PostHotelDetails(Motel motel)
        {
            return await _context.PostMotelDetails(motel);
        }

        [HttpDelete]
        public async Task<string> DeleteMotelDetails(int id)
        {
            try
            {

                {
                    return await _context.DeleteMotelDetails(id);
                }
            }
            catch (Exception) 
            {
                return  "Hotel ID not found";
            }
        }
        [HttpGet]
        public async Task<ActionResult<List<Motel>>> AvailableAminites()
        {
            return await _context.AvailableAminites();
        }

        [HttpGet]
        public async Task<ActionResult<List<Motel>>> Available_Locations()
        {
            return await _context.Available_Locations();
        }

        [HttpGet]
        public async Task<ActionResult<List<Motel>>> AvailableRoomoption()
        {
            return await _context.AvailableRoomoption();
        }

    }
}
