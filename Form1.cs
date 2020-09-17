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
{//Можно ли в коде прописать, что при нажатии на крестик в любой форме кроме первой - просто скрыть форму
    // а если нажать на крестик в форме 1, то закрыть программу.
    //есть ли более простой способ центрировать кнопки?
    //Почему я не могу убрать из кода Методы типа button_click? 
    //Мне сразу конструктор выдает ошибки. Неужели в коде оно должно все время висеть пустым методом?
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
