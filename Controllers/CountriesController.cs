using Microsoft.AspNetCore.Mvc;
using TravelInformationAPI.Models;

namespace TravelInformationAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CountriesController : ControllerBase
{
    private readonly List<Country> _countries = new List<Country>()
    {
        new Country
        {
            Id = 1,
            Name = "France",
            Capital = "Paris",

            PointOfInterests = new List<PointOfInterest>()
            {
                new PointOfInterest
                {
                    Id = 1,
                    Name = "Eiffel Tower",
                    Description = "Eiffel Tower is in Paris"
                },

                new PointOfInterest
                {
                    Id = 2,
                    Name = "Louvre Museum",
                    Description = "Louvre Museum is in Paris"

                }
            }
        },
        
        new Country{
            Id = 2,
            Name = "Italy",
            Capital = "Rome",
            
            PointOfInterests = new List<PointOfInterest>()
            {
                new PointOfInterest
                {
                    Id = 3,
                    Name = "Colosseum",
                    Description = "Colosseum is in Italy"
                },
                new PointOfInterest
                {
                    Id = 4,
                    Name = "Trevi Fountain",
                    Description = "Trevi Fountain is in Italy"
                },
               
            }
        },
        new Country 
        {
            Id = 3,
            Name = "switzerland",
            Capital = "Bern",
            
            PointOfInterests = new List<PointOfInterest>()
            {
                new PointOfInterest
                {
                    Id = 5,
                    Name = "Chillon Castle",
                    Description = "Chillon Castle is in Switzerland"
                    
                },
                new PointOfInterest
                {
                    Id = 6,
                    Name = "Bernina Express",
                    Description = "Bernina Express is in Switzerland"
                    
                }
               
            }
            
            
        }
    };
    
    [HttpGet]
    public ActionResult<IEnumerable<Country>> Get()
    {
        return Ok(_countries);
    }

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        var country = _countries.FirstOrDefault(x => x.Id == id);
        if (country == null)
        {
            return NotFound();
        }
        return Ok(country);
    }
}