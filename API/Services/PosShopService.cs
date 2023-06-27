using API.Models;
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;

namespace API.Services
{
    public class PosShopService : IPosShopService
    {
        private readonly ApplicationDbContext _dbContext;

        public PosShopService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<POSShopDto>> GetShopListAsync()
        {
            var posShop = await (from shop in _dbContext.POSShops
                              select new POSShopDto()
                              {
                                  Id = shop.Id,
                                  Name = shop.Name,
                                  Address = shop.Address,

                              }).ToListAsync();

            return posShop;
        }
    }
}
