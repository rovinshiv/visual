using rovin.Contracts;
using rovin.Data;

namespace rovin.Repository
{
    public class HotelRepository : GenericRepository<Hotel>, IHotelsRepository
    {
        private readonly HotelListingsDbContext _context;
        public HotelRepository(HotelListingsDbContext context) : base(context)
        {
            this._context = context;
        }
    }
}
