using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_OOP.Struct
{
    public partial class StructEG : Form
    {
        public StructEG()
        {
            InitializeComponent();
        }

        private void StructEG_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DragonHood dragonhood = new DragonHood();

            dragonhood.Defence = int.Parse(textBox1.Text);
            dragonhood.BlockoutChance = int.Parse(textBox2.Text);
            dragonhood.SkillRes = int.Parse(textBox3.Text);

            lblSa.Text = dragonhood.Defence.ToString()+" " +dragonhood.BlockoutChance.ToString()+" "+dragonhood.SkillRes.ToString();
        }
    }
}
