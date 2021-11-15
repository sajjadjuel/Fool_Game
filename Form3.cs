using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fool_Game
{
    public partial class Form3 : System.Windows.Forms.Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

       

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Red;
            button1.BackColor = Color.White;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        { 
            button1.ForeColor = Color.WhiteSmoke;
            button1.BackColor = Color.Red;

        }
    }
}
