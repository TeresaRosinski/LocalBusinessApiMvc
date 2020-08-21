using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc; 
using BusinessApi.Models; 

namespace BusinessApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class BusinessesController : ControllerBase
  {
    private BusinessApiContext _db;
    public BusinessesController (BusinessApiContext db)
    {
      _db = db; 
    }

    //Get api/businesses - return businesses
    [HttpGet]
    public ActionResult<IEnumerable<Business>> Get ()
    {
      return _db.Businesses.ToList();
    }

    //POst api/Businesses - create / post Businesses
    [HttpPost]
    public void Post([FromBody] Business business)
    {
      _db.Businesses.Add(business);
      _db.SaveChanges();
    }
  }
}
