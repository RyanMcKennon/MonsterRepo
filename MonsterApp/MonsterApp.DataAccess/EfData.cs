using MonsterApp.DataAccess;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterApp.DataAccess
{
  public class EfData
  {
    private MonsterDBEntities db = new MonsterDBEntities();

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public List<Gender> GetGenders()
    {
      return db.Genders.ToList();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="gender"></param>
    /// <returns></returns>
    public bool InsertGender(Gender gender)
    {
      db.Genders.Add(gender);
      return db.SaveChanges() > 0;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="gender"></param>
    /// <param name="state"></param>
    /// <returns></returns>
    public bool ChangeGender(Gender gender, EntityState state)
    {
      var entry = db.Entry<Gender>(gender);

      entry.State = state;
      return db.SaveChanges() > 0;
    }

    public void SearchGender()
    {
      var actives = db.Genders.Where(a => a.Active);
      var inactives = db.Genders.Select(a => !a.Active);
      var ma = db.Genders.Where(m => m.GenderName.ToLower().Contains("ma"));
    }

    public bool InsertMonster(Monster monster)
        {
            db.Monsters.Add(monster);
            return db.SaveChanges() == 1;
        }
  }
}
