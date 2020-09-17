using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LessonGB7
{
    public partial class Form3 : Form
    {

        public int h;
        public Form3()
        {
            InitializeComponent();
            Text = "Угадай число";
            Random r = new Random();
            h = r.Next(1, 100);
            var formWidth = Width;
            var lblHelpWidth = lblHelp.Width;
            lblHelp.Width = (formWidth - lblHelpWidth) / 2;


        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string num = txtNumEnt.Text;
            
            
            
            try
            {
                int f = Convert.ToInt32(num);
                int s = h - f;
                if (s < 0)
                {
                    lblHelp.Text = "Введите меньшее число";
                }
                else if (s > 0)
                {
                    lblHelp.Text = "Введите большее число";
                }
                else if (s == 0)
                {
                    lblHelp.Text = "Вы победили";
                }
            }
            catch 
            {
                lblHelp.Text = "Введите число!";
            }
              
            
        }

       
        private void lblHelp_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
            new Form1().Show();
        }
    }
}
