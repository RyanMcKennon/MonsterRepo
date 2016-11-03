using MonsterApp.DataAccess;
using DA = MonsterApp.DataAccess.Models;
using MonsterApp.DataClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonsterApp.DataClient
{
  public class GenderMapper
  {
    public static GenderDAO MapToGenderDAO(DA.Gender gender)
    {
      var g = new GenderDAO();

      g.Id = gender.GenderId;
      g.Name = gender.Name;

      return g;
    }

    public static DA.Gender MapToGender(GenderDAO gender)
    {
      throw new NotImplementedException();
    }

    public static object MapTo(object o)
    {
      var properties = o.GetType().GetProperties();
      var ob = new object();

      foreach (var item in properties.ToList())
      {
        ob.GetType().GetProperty(item.Name).SetValue(ob, item.GetValue(item));
      }

      return ob;
    }
  }
}