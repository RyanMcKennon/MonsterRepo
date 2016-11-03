using MonsterApp.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MonsterApp.Tests
{
  public partial class AdoDataTests
  {
    [Fact]
    public void Test_GetGenders()
    {
      var data = new AdoData();
      var actual = data.GetGenders();

      Assert.NotNull(actual);
    }
  }
}
