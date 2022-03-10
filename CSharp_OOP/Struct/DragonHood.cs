using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_OOP.Struct
{
    //The struct (structure) is like a class in C# that is used to store data. However, unlike classes, a struct is a value type.

    //we use the struct keyword to define a struct. For example
    public struct DragonHood
    {
        public int Defence;
        public int BlockoutChance;
        public int SkillRes;

        //create constructor
        //Note: we can not create parameterless constructors!!!
        public DragonHood(int defence, int blockoutchance, int skillres)
        {
            this.Defence = defence;
            this.BlockoutChance = blockoutchance;
            this.SkillRes = skillres;
        }
    }
}
