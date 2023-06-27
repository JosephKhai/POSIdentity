using API.Models;

namespace API.Services
{
    public interface IPosShopService
    {
        Task<List<POSShopDto>> GetShopListAsync();
    }
}
