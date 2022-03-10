using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_OOP.Class
{
    public partial class ClassEG : Form
    {
        public ClassEG()
        {
            InitializeComponent();
        }

        private void ClassEG_Load(object sender, EventArgs e)
        {
            
            

        }

        private void button1_Click(object sender, EventArgs e)
        {//if you wanna use the class you created. you have to define an instance.
            //"ClassName + variableName + = + new + ClassName"
            //E.G
            PoisonSword psword = new PoisonSword();

            //we defined an instance.Now you can assign value and read value.
            psword.AttackSpeed = int.Parse(textBox2.Text);
            psword.AttackValue = int.Parse(textBox1.Text);
            psword.SkillDamage = int.Parse(textBox3.Text);

            MessageBox.Show($"Attack Speed: {psword.AttackSpeed}\nAttack Value: {psword.AttackValue}\nSkillDamage: {psword.SkillDamage} ");

        }
    }
}
