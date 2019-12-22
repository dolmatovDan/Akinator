using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = false;
            pictureBox1.Visible = false;
            textBox1.Visible = false;
            
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
          

        }
        int step = 0;
        void game()
        {
            if (step == 0)
            {
                pictureBox1.Visible = false;
                textBox1.Visible = true;
                
                richTextBox1.Text = "Персонаж человек?\n Нужно ответить да/нет";
                button1.Text = "Следующий вопрос";
                step++;
                textBox1.Text = "";
            }
            else if (step == 1)
            {

                if (textBox1.Text.ToLower() == "да")
                {
                    richTextBox1.Text = "Это мужчина?\n Нужно ответить да/нет";
                    step++;
                }
                else if (textBox1.Text.ToLower() == "нет")
                {
                    richTextBox1.Text = "Он демон?";
                    step = 6;
                }
            }
            else if (step == 6)
            {

                if (textBox1.Text.ToLower() == "да")
                {
                    richTextBox1.Text = "Это Кроули";
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Properties.Resources.krouli;
                    step = 12;
                    startGame();
                }
                else if (textBox1.Text.ToLower() == "нет")
                {
                    richTextBox1.Text = "Это ангел?\n Нужно ответить да/нет";
                    step++;
                }
            }
            else if (step == 7)
            {
                if (textBox1.Text.ToLower() == "да")
                {
                    richTextBox1.Text = "Это Кастиэль?\n Нужно ответить да/нет";
                    step++;
                }
                else if (textBox1.Text.ToLower() == "нет")
                {
                    richTextBox1.Text = "Это король вампиров";
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Properties.Resources.alfa;
                    step = 12;
                    startGame();
                }
            }
            else if (step == 8)
            {
                if (textBox1.Text.ToLower() == "да")
                {
                    richTextBox1.Text = "Это Кастиэль";
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Properties.Resources.kas;
                    step = 12;
                    startGame();
                }
                else if (textBox1.Text.ToLower() == "нет")
                {
                    richTextBox1.Text = "Он хороший?";
                    step++;
                }
            }
            else if (step == 9)
            {
                if (textBox1.Text.ToLower() == "да")
                {
                    richTextBox1.Text = "Это Чак";
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Properties.Resources.chak;
                    step = 12;
                    startGame();
                }
                else if (textBox1.Text.ToLower() == "нет")
                {
                    richTextBox1.Text = "Это Люцифер";
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Properties.Resources.lucifer;
                    step = 12;
                    startGame();
                }
            }
            else if (step == 2)
            {

                if (textBox1.Text.ToLower() == "да")
                {
                    richTextBox1.Text = "Это Винчестер?\n Нужно ответить да/нет";
                    step++;

                }
                else if (textBox1.Text.ToLower() == "нет")
                {
                    richTextBox1.Text = "У неё есть дети?";
                    step = 11;
                }
            }
            else if (step == 3)
            {

                if (textBox1.Text.ToLower() == "да")
                {
                    richTextBox1.Text = "Это Сэм?\n Нужно ответить да/нет";
                    step++;

                }
                else if (textBox1.Text.ToLower() == "нет")
                {
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Properties.Resources.boby;
                    step = 12;
                    startGame();
                }
            }
            else if (step == 4)
            {

                if (textBox1.Text.ToLower() == "да")
                {
                    richTextBox1.Text = "Это Сэм?";
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Properties.Resources.sam;
                    step = 12;
                    startGame();
                }
                else if (textBox1.Text.ToLower() == "нет")
                {
                    richTextBox1.Text = "Это Дин?\n Нужно ответить да/нет";
                    step++;
                }
            }
            else if (step == 5)
            {

                if (textBox1.Text.ToLower() == "да")
                {
                    richTextBox1.Text = "Это Дин";
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Properties.Resources.din;

                }
                else if (textBox1.Text.ToLower() == "нет")
                {
                    richTextBox1.Text = "Это Джон";
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Properties.Resources.jon;
                }
                step = 12;
                startGame();
            }
            else if (step == 11)
            {

                if (textBox1.Text.ToLower() == "да")
                {
                    richTextBox1.Text = "Это Джо";
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Properties.Resources.jo;

                }
                else if (textBox1.Text.ToLower() == "нет")
                {
                    richTextBox1.Text = "Это Эллен";
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Properties.Resources.ellen;

                }
                step = 12;
                startGame();

            }
            else if (step == 12)
            {
                step = 0;
                pictureBox1.Visible = false;
                button1.PerformClick();
                
            }


        }

        private void startGame()
        {
                this.KeyPreview = true;
                pictureBox1.Visible = false;
       

                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

                private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            game();
        }
        private void Button1_KeyDown1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                game();
            }
            
        }

    }
}
