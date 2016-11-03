using MonsterWeb.Logic.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterWeb.Logic.models
{
    public partial class MonsterDTO : MonsterThing
    {
        partial void IsNull(ref string data, string value);

        private string _Name = default(string);
        private string _Gender = default(string);
        private string _Type = default(string);

        public Guid Id { get; set; }
        /// <summary>
        /// 
        /// </summary>

        public override string Name
        {
            get
            {
                return _Name;
            }
            protected set
            {
                IsNull(ref _Name, value);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        public string GenderID
        {
            get
            {
                return _Gender;
            }
            set
            {
                IsNull(ref _Gender, value);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string TypeID
        {
            get
            {
                return _Type;
            }
            set
            {
                IsNull(ref _Type, value);
            }
        }


        public new DateTime Creation { get; set; }

        public MonsterDTO(string name, string genderId, string typeId) :base()
        {
            //int tempGender;
            //int tempType;
            //int.TryParse(genderId, out tempGender);
            //int.TryParse(typeId, out tempType);

            Name = name;
            GenderID = genderId;
            TypeID = typeId;


        }

        /// <summary>
        /// 
        /// </summary>
        ~MonsterDTO()
        {
            GC.Collect();
        }
        
    }
}
