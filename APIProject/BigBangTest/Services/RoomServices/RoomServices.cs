using BigBangTest.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol;

namespace BigBangTest.Services.RoomServices
{
    public class RoomServices : IRoomServices
    {
        private readonly ApplicationDbContext _context;
        public RoomServices(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ActionResult<object>> GetRoomDetails()
        {
            var room = await _context.Room.ToListAsync();
            return room;
        }


        public async Task<ActionResult<object>> PostRoomDetails(Room room)
        {
           var rooms= _context.Add(room);
            _context.SaveChanges();
            return rooms;
        }

        public async Task<List<Room>> AvailableRooms()
        {
            var rooms =  _context.Room.Where(x => x.Property_Type=="Fully Furnished").ToListAsync();
            return await rooms;

        }

        public async Task<List<Room>> RoomBYPrice()
        {
            var rooms = _context.Room.Where(x => x.price>= 10000.00).ToListAsync();
            return await rooms;
        }

        public async Task<string> DeleteRoomDetails(int id)
        {
            _context.Remove(id);
            _context.SaveChanges();
            return "Deleted";
        }


        public async Task<ActionResult<object>> RoomsCount()
        {
            var counts =  _context.Room.Count();
            return counts;
        }

    }
}
