using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using тема_1;

namespace тема2
{
    public partial class Topic2Test2 : Form
    {
        private int n = 0;
        private int points = 0;
        private String[] questions = new string[10] {
                "Имеете ли вы опыт работы с языком программирования\n"+" Python не менее 2-х лет?",
                "Знаете ли вы основы работы с базами данных (например, SQL)?  ",
                "Работали ли вы с системами контроля версий (например, Git)?\n",
                "Имеете ли вы опыт разработки веб-приложений?",
                "Знакомы ли вы с методологиями разработки ПО,\n"+" такими как Agile или Scrum?  ",
                "Готовы ли вы к обучению новым технологиям\n"+" и языкам программирования?  ",
                "Имеете ли вы опыт работы в команде разработчиков?\n",
                "Участвовали ли вы в открытых проектах\n"+"или программировании с использованием GitHub?",
                "Знаете ли вы принципы тестирования и отладки кода?",
                "Способны ли вы разрабатывать документацию для своего кода?  "};
        public Topic2Test2()
        {
            InitializeComponent();
            label3.Hide();
            groupBox1.Hide();
            button2.Hide();
            button3.Hide();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            label2.Text = (n + 1).ToString() + "/10";
            Button1.Hide();
            label3.Visible = true;
            label3.Text = questions[n];
            groupBox1.Visible = true;
            button2.Visible = true;
            n++;
        }
        private void ShowAnswer(int p)
        {
            label2.Hide();
            groupBox1.Hide();
            button2.Hide();
            if (points <=3)
            {
                label3.Text = $"Ваш результат: {points} баллов\n\n" +
                "Низкий уровень квалификации.\n"+"Рекомендуется дополнительное обучение.\n";
            }
            else if (points >= 4 && points <= 6)
            {
                label3.Text = $"Ваш результат: {points} баллов\n\n" +
                    "Средний уровень квалификации.\n"+"Возможно, потребуется обучение.";
            }
            else if (points >= 7 && points <= 10)
            {
                label3.Text = $"Ваш результат: {points} баллов\n\n" +
                    "Высокий уровень квалификации.\n"+"Кандидат подходит для работы.";
            }
            button3.Visible = true;
        }
        private void NextQuestion(int num)
        {
            if (num < 10)
            {
                label2.Text = (n + 1).ToString() + "/10";
                label3.Text = questions[n];
            }
            if (num == 10)
                ShowAnswer(points);
            n++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!radioButton1.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("Выберите вариант 'да' или 'нет'");
                return;
            }
            if (radioButton1.Checked)
            {
                points++;
                NextQuestion(n);
            }
            else if (radioButton2.Checked)
            {
                NextQuestion(n);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Topic2Test3 test3 = new Topic2Test3();
            test3.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainWindow main = new MainWindow();
            main.Show();
        }
    }
}
