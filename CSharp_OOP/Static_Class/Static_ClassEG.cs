using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_OOP.Static_Class
{
    public partial class Static_ClassEG : Form
    {
        public Static_ClassEG()
        {
            InitializeComponent();
        }

        private void Static_ClassEG_Load(object sender, EventArgs e)
        {
            // as you can see we did not need to define instance. i mean we can assign value without define instance
            BlackSteelArmour.Level = 65;
            BlackSteelArmour.MovementSpeed = 110;
            BlackSteelArmour.MagicResistance = 48;
        }
    }
}
