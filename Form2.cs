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
   
    public partial class Form2 : Form
    {
        public int f;
        public Form2()
        {
            InitializeComponent();
            btnCommand1.Text = "+1";
            btnCommand2.Text = "x2";
            btnReset.Text = "Сброс";
            lblNumber.Text = "0";
            Text = "Удвоитель";
            CommandCount.Text = "0";
            btnExit.Text = "Меню";


            Random r = new Random();
            
            f = r.Next(1, 100);
           
            TextEx.Text = $"Добро пожаловать в Удвоитель! Накликайте число {f.ToString()} за наименьшее число ходов, что бы победить!";
            Graphics g = Graphics.FromHwnd(this.Handle);
            SizeF h = g.MeasureString(TextEx.Text, TextEx.Font); //берем присвоенный текст и текущий фонт
            TextEx.Width = (int)(h.Width);
            var formWidth = Width;
            var textExWidth = TextEx.Width;
            TextEx.Left = (formWidth - textExWidth) / 2;

            label3.Hide();

            
          

        }
    

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void btnCommand1_Click_1(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();
            CommandCount.Text = (int.Parse(CommandCount.Text) + 1).ToString();
            CheckResult();
        }

        private void btnCommand2_Click_1(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) * 2).ToString();
            CommandCount.Text = (int.Parse(CommandCount.Text) + 1).ToString();
            CheckResult();
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            lblNumber.Text = "0";
            CommandCount.Text = "0";
        }

        private void lblNumber_Click_1(object sender, EventArgs e)
        {

        }

        private void CommandCount_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TextEx_TextChanged(object sender, EventArgs e)
        {

        }

        private void CheckResult()
        {
            string num = lblNumber.Text;
            try
            {
                int h = Convert.ToInt32(num);
                int s = f - h;
                
                if (s == 0)
                {
                    label3.Show();
                }
            }
            catch
            {
               
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
            new Form1().Show();
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
