using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_OOP.Class
{
     class PoisonSword //default internal. you create public class you cant use members of the class in other class
    {
        //if you wanna use any field in your project(different class) you have to make it public!!!
       public int AttackValue;
       public int AttackSpeed;
       public int SkillDamage;

    }
}
