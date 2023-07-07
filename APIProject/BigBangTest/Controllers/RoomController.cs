using BigBangTest.Models;
using BigBangTest.Services.RoomServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BigBangTest.Controllers
{
    
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomServices _Context;

        public RoomController(IRoomServices context)
        {
            _Context = context;
        }


        [HttpGet]
        public async Task<ActionResult<object>> GetRoomDetails()
        {
            return await _Context.GetRoomDetails();
        }

        [HttpPost]
        public async Task<ActionResult<object>> PostRoomDetails(Room room)
        {
            return await _Context.PostRoomDetails(room);
        }

        [HttpGet]
        public async Task<ActionResult<List<Room>>> AvailableRooms()
        {

            return await _Context.AvailableRooms();
        }

        [HttpDelete]
        public async Task<string> DeleteRoomDetails(int id)
        {
            try
            {
                return await _Context.DeleteRoomDetails(id);
            }
            catch
            {
                return "Room not found";
            }
        }

        [HttpGet]
        public async Task<ActionResult<List<Room>>> RoomBYPrice()
        {
            return await _Context.RoomBYPrice();
        }

        [HttpGet]
        public async Task<ActionResult<object>> RoomsCount()
        {
            return await _Context.RoomsCount();
        }
    }
}
