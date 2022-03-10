using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_OOP.Constructors
{
    public partial class BattleShieldEG : Form
    {
        public BattleShieldEG()
        {
            InitializeComponent();
        }

        private void BattleShieldEG_Load(object sender, EventArgs e)
        {
            //without parameter
            BattleShield bShield = new BattleShield(); // defined an instance
            MessageBox.Show(bShield.Defence.ToString());
            //with one parameter
            BattleShield bShield1 = new BattleShield(22); //define an instance
            MessageBox.Show(bShield1.LycanDef.ToString());
            //with a few parameters
            BattleShield bShield2 = new BattleShield(31,20); //define an instance
            MessageBox.Show(bShield2.SuraDef.ToString()+" "+bShield2.WarriorDef.ToString());
        }
    }
}
