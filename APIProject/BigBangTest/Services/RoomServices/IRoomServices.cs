using BigBangTest.Models;
using Microsoft.AspNetCore.Mvc;

namespace BigBangTest.Services.RoomServices
{
    public interface IRoomServices
    {
        Task<ActionResult<object>> GetRoomDetails();
        Task<ActionResult<object>> PostRoomDetails(Room room);
        Task<List<Room>> AvailableRooms();

        Task<List<Room>> RoomBYPrice();

        Task<string> DeleteRoomDetails(int id);

        Task<ActionResult<object>> RoomsCount();
    }
}
