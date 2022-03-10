using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_OOP.PropertiesAndEncapsulation
{
     class OceanicShoes
    {
        //Property in C# is a member of a class that provides a flexible mechanism for classes to expose private fields. Internally, C# properties are special methods called accessors. A C# property have two accessors, get property accessor and set property accessor. A get accessor returns a property value, and a set accessor assigns a new value. The value keyword represents the value of a property.

        //shortcut prop + tab + tab
        public int Defence { get; set; }
        public int MovementSpeed { get; set; }

        //encapsulation is a protective shield that prevents the data from being accessed by the code outside this shield.
        //E.G
        int skillResistance; // default private
        public int SkillResistance 
        {
            get
            {
                return 31;
            }    //now anyone can just read this field but nobody can assign value. So we have protected this member
            
        }
    }
}
