using MonsterWeb.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MonsterWeb.Tests
{
  public class ServiceTests
  {
    [Fact]
    public void Test_GetGenders()
    {
      var service = new DataService();
      var actual = service.GetGenders();

      Assert.NotNull(actual);
    }
  }
}
