using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using rovin.Configurations;
using rovin.Contracts;
using rovin.Data;
using rovin.Models.Country;

namespace rovin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        private readonly HotelListingsDbContext _context;
        private readonly IMapper _mapper;
        private readonly ICountriesRepository _countryrepository;
        public CountriesController(IMapper mapper, ICountriesRepository countryrepository, HotelListingsDbContext context)
        {
            this._countryrepository = countryrepository;
            this._mapper = mapper;
            this._context = context;
        }

        // GET: api/Countries
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetCountryDetails>>> GetCountry()
        {

            var country = await _countryrepository.GetAllAsync();
            var records = _mapper.Map<List<GetCountry>>(country);
            return Ok(records);
            //var countries = await _context.Country.ToListAsync();
            //return Ok(countries);
        }

        // GET: api/Countries/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GetCountryDetails>> GetCountry(int id)
        {

            var country = await _countryrepository.GetDetails(id);
            if (country == null)
            {
                return NotFound();
            }
           var CountryDto = _mapper.Map<GetCountryDetails>(country);
            return Ok(CountryDto);
        }

        // PUT: api/Countries/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCountry(int id, UpdateCountry updatecountry)
        {
            if (id != updatecountry.Id)
            {
                return BadRequest();
            }

            var country = await _countryrepository.GetAsync(id);
            if(country == null)
            {
                return NotFound();
            }

            _mapper.Map(updatecountry, country);
            try
            {
                await _countryrepository.UpdateAsync(country);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (! await CountryExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Countries
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Country>> PostCountry(CreateCountry createCountry)
        {
          
            var country = _mapper.Map<Country>(createCountry);
            await _countryrepository.AddAsync(country);

            return CreatedAtAction("GetCountry", new { id = country.Id }, country);
        }

        // DELETE: api/Countries/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCountry(int id)
        {

            var country = await _countryrepository.GetAsync(id);
            if (country == null)
            {
                return NotFound();
            }

            await _countryrepository.DeleteAsync(id);

            return NoContent();
        }

        private async Task<bool> CountryExists(int id)
        {
            return await _countryrepository.Exists(id);
        }
    }
}
