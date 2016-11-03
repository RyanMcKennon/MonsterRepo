using MonsterApp.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MonsterApp.Tests
{
  /// <summary>
  /// 
  /// </summary>
  public class EfDataTests
  {
    [Fact]
    public void Test_GetGenders()
    {
      var data = new EfData();
      var actual = data.GetGenders();

      Assert.NotNull(actual);
    }

        [Fact]
        public void Test_EfInsertMonster()
        {
            var data = new EfData();
            var expected = new Monster() { Name = "bob", GenderId = 2, TypeId = 1 };
            var actual = data.InsertMonster(expected);

            Assert.True(actual);
        }

    [Fact]
    public void Test_InsertGender()
    {
      var data = new EfData();
      var expected = new Gender() { GenderName = "Martian", Active = true };

      var actual = data.ChangeGender(expected, System.Data.Entity.EntityState.Added);

      Assert.True(actual);
    }
  }
}
