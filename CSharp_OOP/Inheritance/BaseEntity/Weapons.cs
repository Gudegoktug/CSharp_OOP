using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_OOP.Inheritance
{
    // it is possible to inherit fields and methods from one class to another. it is useful for code reusability
    public class Weapons //its our base class
    {
        public int Level { get; set; }
        public int AttackValue { get; set; }
        public int AttackSpeed { get; set; }
    }
}
