using Models = MonsterApp.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterApp.DataAccess
{
  /// <summary>
  /// 
  /// </summary>
  public partial class AdoData
  {
    private string connectionString = ConfigurationManager.ConnectionStrings["MonsterDB"].ConnectionString;

    #region Methods

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public List<Models.Gender> GetGenders()
    {
      try
      {
        var ds = GetDataDisconnected("select * from Monster.Gender;");
        var genders = new List<Models.Gender>();

        foreach (DataRow row in ds.Tables[0].Rows)
        {
          genders.Add(new Models.Gender()
          {
            GenderId = int.Parse(row[0].ToString()),
            Name = row[1].ToString(),
            Active = bool.Parse(row[2].ToString())
          });
        }

        return genders;
      }
      catch (Exception ex)
      {
        Debug.WriteLine(ex);
        return null;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public List<MonsterType> GetMonsterTypes()
    {
      throw new NotImplementedException("todo");
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public List<Title> GetTitles()
    {
      throw new NotImplementedException("todo");
    }

    #endregion

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    private DataSet GetDataDisconnected(string query)
    {
      SqlDataAdapter da;
      DataSet ds;
      SqlCommand cmd;

      using (var connection = new SqlConnection(connectionString))
      {
        cmd = new SqlCommand(query, connection);
        da = new SqlDataAdapter(cmd);
        ds = new DataSet();

        da.Fill(ds);
      }

      return ds;
    }
  }
}
