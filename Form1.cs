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
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.S)
            {
                Form3 nextForm = new Form3();
                this.Hide();
                nextForm.ShowDialog();
                this.Close();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
      
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Tag = this;
            f2.Show();
            Hide();
        }
        int i = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            
        } 
    
        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void button1_MouseEnter_1(object sender, EventArgs e)
        {
            Random x = new Random();
            i++;
            Point p = new Point(
            int.Parse(x.Next(550).ToString()),
            int.Parse(x.Next(350).ToString())
            );
            button1.Location = p;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.GreenYellow;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = SystemColors.ActiveBorder;
        }
    }
}
