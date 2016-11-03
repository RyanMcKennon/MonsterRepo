using MonsterWeb.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MonsterWeb.Client
{
  public partial class _default : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      GetGenders();
    }

    private void GetGenders()
    {
      var data = new DataService();
      genderlist.Items.Clear();

      foreach (var item in data.GetGenders())
      {
        genderlist.Items.Add(item.Name);
      }
    }
  }
}