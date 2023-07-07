using BigBangTest.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.EntityFrameworkCore;

namespace BigBangTest.Services.MotelServices
{
    public class MotelServices : IMotelServices
    {
        private readonly ApplicationDbContext _context;
        public MotelServices(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<Motel>> GetMotelDetails()
        {
            var hotel = await _context.Motel.ToListAsync();
            return hotel;
        }
        public async Task<ActionResult<Motel>> PostMotelDetails(Motel motel)
        {
            _context.Add(motel);
            _context.SaveChanges();
            return motel;
        }

        public async Task<string> DeleteMotelDetails(int id)
        {
            var motel = _context.Motel.FirstOrDefault(x => x.motel_Id == id);
            _context.Motel.Remove(motel);
            _context.SaveChanges();
            return "Deleted";
        }
        public async Task<List<Motel>> AvailableAminites()
        {
            var Hotel = _context.Motel.Where(x => x.Amenities == "SPA" || x.Amenities == "GYM" || x.Amenities == "Cafe" || x.Amenities == "Bar").ToListAsync();
            return await Hotel;
        }
        public async Task<List<Motel>> AvailableRoomoption()
        {
            var Hotel = _context.Motel.Where(x => x.RoomOptions=="Free Wi-Fi" || x.RoomOptions == "Free BreakFast" || x.RoomOptions == "Free Cancellation").ToListAsync();
            return await Hotel;
        }
        public async Task<List<Motel>> Available_Locations()
        {
            var Hotel = _context.Motel.Where(x => x.Location == "Chennai" || x.Location == "Banglore").ToListAsync();
            return await Hotel;
        }
    }
}
