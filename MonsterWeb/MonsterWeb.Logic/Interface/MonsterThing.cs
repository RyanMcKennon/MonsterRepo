using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterWeb.Logic.Interface
{
    public abstract class MonsterThing : Thing
    {
        public Guid Id { get;}

        virtual public string Name { get; protected set; }
        public DateTime Creation { get; }
        protected MonsterThing()
        {
            Id = Guid.NewGuid();
        }
    }
}
