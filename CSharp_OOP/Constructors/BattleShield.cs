using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_OOP.Constructors
{
    internal class BattleShield
    {
       // A constructor is a special method that is used to initialize objects.The advantage of a constructor, is that it is called when an object of a class is created.It can be used to set initial values for fields:

        //create property
        public int Defence { get; set; }
        public int LycanDef { get; set; }
        public int WarriorDef { get; set; }
        public int SuraDef { get; set; }


        //must be the same as the class name
        // create constructor
        // shortcut ctor + tab + tab
        public BattleShield()
        {
            Defence = 31;
        }


        //Constructors can also take parameters, which is used to initialize fields.
        //E.G
        public BattleShield(int lycanDef)
        {
            LycanDef = lycanDef;

        }

        //You can have as many parameters as you want
        public BattleShield(int warriorDef, int suraDef)
        {
            WarriorDef = warriorDef;
            SuraDef = suraDef;
        }
    }
}
