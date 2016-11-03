using MonsterWeb.Logic.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterWeb.Logic
{
    public class FactoryThing<T> where T : new()
    {
        public T Create() //where T : MonsterThing, new()
        {
            return new T();
        }
    }
}
