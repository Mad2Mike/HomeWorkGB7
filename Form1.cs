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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            Text = "Меню";
            btnUdvoitel.Text = "Играть в Удвоитель";
            btnUgadayCh.Text = "Играть в Угадай число";
            btnExit.Text = "Выйти из приложения";
            var formWidth = Width;
            var btnUdvoitelWidth = btnUdvoitel.Width;
            btnUdvoitel.Left = (formWidth - btnUdvoitelWidth) / 2;
            var btnExitWidth = btnExit.Width;
            btnExit.Left = (formWidth - btnExitWidth) / 2;
            var btnUgadayChWidth = btnUgadayCh.Width;
            btnUgadayCh.Left = (formWidth - btnUgadayChWidth) / 2;
            




        }

        private void btnUdvoitel_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            Hide();
        }

        private void btnUgadayCh_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
   
    }
}
