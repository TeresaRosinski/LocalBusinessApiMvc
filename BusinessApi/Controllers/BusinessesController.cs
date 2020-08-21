using System; 
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc; 
using BusinessApi.Models; 
using Microsoft.EntityFrameworkCore;

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
    public ActionResult<IEnumerable<Business>> Get (string name, string type, string city, string description, bool random )
    {
      var query = _db.Businesses.AsQueryable();
      if (name != null)
        {
          query = query.Where(entry => entry.Name == name);
        } 
      if (type != null)
        {
          query = query.Where(entry => entry.Type == type);
        } 
      if (city != null)
        {
          query = query.Where(entry => entry.City == city);
        } 
      if (description != null)
        {
        query = query.Where(entry => entry.Description == description);
        } 
      if (random)
      {
        Random rdn = new Random();
        int MaxId = _db.Businesses.Max(entry=>entry.BusinessId);
        query = query.Where(entry=>entry.BusinessId == rdn.Next(MaxId));
      }
      
      return query.ToList();
    }

    //POst api/Businesses - create / post Businesses
    [HttpPost]
    public void Post([FromBody] Business business)
    {
      _db.Businesses.Add(business);
      _db.SaveChanges();
    }

    //Get api/Businesses/5
    [HttpGet("{id}")]
    public ActionResult<Business> Get (int id)
    {
      return _db.Businesses.FirstOrDefault(entry => entry.BusinessId == id);
    }

    //Put api/businesses/5
    [HttpPut("{id}")]
    public void Put (int id, [FromBody] Business business)
    {
      business.BusinessId = id; 
      _db.Entry(business).State = EntityState.Modified;
      _db.SaveChanges();
    }

    //Delete api/businesses/5
    [HttpDelete("{id}")]
    public void Delete (int id)
    {
      var businessToDelete = _db.Businesses.FirstOrDefault(entry => entry.BusinessId == id);
      _db.Businesses.Remove(businessToDelete);
      _db.SaveChanges();
    }
  }
}
