using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using AnimalShelter.Models;

namespace AnimalShelter.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class DogsController : ControllerBase
  {
    private AnimalShelterContext _db;
    public DogsController(AnimalShelterContext db)
    {
      _db = db;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Dog>> Get()
    {
      return _db.Dogs.ToList();
    }

    [HttpPost]
    public void Post([FromBody] Dog dog)
    {
      _db.Dogs.Add(dog);
      _db.SaveChanges();
    }
  }
}