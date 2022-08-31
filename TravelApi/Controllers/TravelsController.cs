using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TravelApi.Models;

namespace TravelApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class TravelsController : ControllerBase
  {
    private readonly TravelApiContext _db;

    public TravelsController(TravelApiContext db)
    {
      _db = db;
    }

    // GET: api/Travels
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Travel>>> Get(string blerb, string location, string country, int minimumRating)
    {
      IQueryable<Travel> query = _db.Travels.AsQueryable();

      if (blerb != null)
      {
        query = query.Where(entry => entry.Blerb == blerb);
      }
      if (location != null)
      {
        query = query.Where(entry => entry.Location == location);
      }
      if (country != null)
      {
        query = query.Where(entry => entry.Country == country);
      }
      if (minimumRating > 0)
      {
        query = query.Where(entry => entry.Rating >= minimumRating);
      }
      return await query.ToListAsync();
    }

    // GET: api/Travels/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Travel>> GetTravel(int id)
    {
        var travel = await _db.Travels.FindAsync(id);

        if (travel == null)
        {
            return NotFound();
        }

        return travel;
    }

    // PUT: api/Travels/5
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Travel travel)
    {
      if (id != travel.TravelId)
      {
        return BadRequest();
      }

      _db.Entry(travel).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!TravelExists(id))
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

    // POST: api/Travels
    [HttpPost]
    public async Task<ActionResult<Travel>> Post(Travel travel)
    {
      _db.Travels.Add(travel);
      await _db.SaveChangesAsync();

      return CreatedAtAction(nameof(GetTravel), new { id = travel.TravelId }, travel);
    }

    // DELETE: api/Travels/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteTravel(int id)
    {
      var travel = await _db.Travels.FindAsync(id);
      if (travel == null)
      {
        return NotFound();
      }

      _db.Travels.Remove(travel);
      await _db.SaveChangesAsync();

      return NoContent();
    }

    private bool TravelExists(int id)
    {
      return _db.Travels.Any(e => e.TravelId == id);
    }
  }
}