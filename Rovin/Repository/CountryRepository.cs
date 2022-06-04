using Microsoft.EntityFrameworkCore;
using rovin.Contracts;
using rovin.Data;

namespace rovin.Repository
{
    public class CountryRepository : GenericRepository<Country>, ICountriesRepository
    {

        private readonly HotelListingsDbContext _context;
        public CountryRepository(HotelListingsDbContext context) : base(context)
        {
            this._context = context;
        }

        public async Task<Country> GetDetails(int id)
        {
         return await _context.Country.Include(s => s.Hotels).FirstOrDefaultAsync(s => s.Id == id);
        }

    
    }
}
