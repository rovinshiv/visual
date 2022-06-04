
using rovin.Data;

namespace rovin.Contracts

{
    public interface ICountriesRepository : IGenericRepository<Country>
    {
        Task<Country> GetDetails(int id);
    }
}
