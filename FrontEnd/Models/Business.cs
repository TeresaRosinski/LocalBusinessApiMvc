using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace FrontEnd.Models
{
  public class Business
  {
    public int BusinessId {get;set;}
    public string Name {get;set;}
    public string City {get;set;}
    public string Type {get;set;}
    public string Description {get;set;}

    public static List<Business> GetBusinesses() //correct according to lesson
    {
      var apiCallTask = ApiHelper.GetAll();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Business> businessList = JsonConvert.DeserializeObject<List<Business>>(jsonResponse.ToString());

      return businessList;
    }

    public static Business GetDetails(int id) //slightly different end point than from code above
    {
      var apiCallTask = ApiHelper.Get(id);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      Business business = JsonConvert.DeserializeObject<Business>(jsonResponse.ToString());

      return business;
    }

    public static void Post(Business business)
    {
      string jsonBusiness = JsonConvert.SerializeObject(business);
      var apiCallTask = ApiHelper.Post(jsonBusiness);
    }

    public static void Put(Business business)
    {
      string jsonBusiness = JsonConvert.SerializeObject(business);
      var apiCallTask = ApiHelper.Put(business.BusinessId, jsonBusiness);
    }

    public static void Delete(int id)
    {
      var apiCallTask = ApiHelper.Delete(id);
    }
  }
}