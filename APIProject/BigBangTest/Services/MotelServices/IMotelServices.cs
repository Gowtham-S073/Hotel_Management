using BigBangTest.Models;
using Microsoft.AspNetCore.Mvc;

namespace BigBangTest.Services.MotelServices
{
    public interface IMotelServices
    {
        Task<List<Motel>> GetMotelDetails();
        Task<ActionResult<Motel>> PostMotelDetails(Motel motel);
        Task<string> DeleteMotelDetails(int id);
        Task<List<Motel>> AvailableRoomoption();

        Task<List<Motel>> AvailableAminites();
        Task<List<Motel>> Available_Locations();

    }
}
