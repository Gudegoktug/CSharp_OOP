using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_OOP.PropertiesAndEncapsulation
{
    public partial class PropAndEncapsulationEG : Form
    {
        public PropAndEncapsulationEG()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OceanicShoes oshoes = new OceanicShoes();  //defined an instance

            oshoes.MovementSpeed = int.Parse(textBox2.Text);
            oshoes.Defence = int.Parse(textBox1.Text);
            // oshoes.SkillResistance = int.Parse(textBox3.Text); we cant assign value because it is read only
            MessageBox.Show($"SkillResistance = {oshoes.SkillResistance}\nDefence: {oshoes.Defence}\nMovementSpeed: {oshoes.MovementSpeed}");
        }
    }
}
