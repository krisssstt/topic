using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace тема2
{
    public partial class Topic2Test3 : Form
    {
        private int n = 0;
        private int points = 0;
        private String[] questions = new string[10] {
                "Какой из следующих языков программирования\n"+" наиболее популярен для веб-разработки?",
                "Какой метод разработки программного обеспечения\n"+"предполагает итеративный подход\n"+"и тесное взаимодействие с клиентом?",
                "Какой инструмент управления версиями кода позволяет\n"+"отслеживать изменения и координировать\n"+"работу нескольких разработчиков?",
                "Какое из следующих понятий связано\n"+"с проектированием баз данных?",
                "Какой тип тестирования программного обеспечения\n"+"ориентирован на проверку работы отдельных\n"+"компонентов программы?\n",
                "Какой алгоритм поиска в массиве является\n"+ "наиболее эффективным для отсортированных данных?",
                "Какой протокол используется для передачи данных\n"+ "по сети в веб-браузере?",
                "Какой из следующих инструментов является средой\n"+ "разработки для Python?",
                "Какой принцип объектно-ориентированного\n"+"программирования предполагает скрытие данных\n"+ "и доступ к ним через методы?",
                "Какой из следующих подходов к разработке\n" +"программного обеспечения помогает поддерживать\n" +"высокое качество кода и минимизировать ошибки?"};
        private String[] answer1 = new string[10] {
            "COBOL",
            "Водопадная модель ",
            "Trello ",
            "ООП",
            "Приемочное тестирование",
            "Поиск перебором ",
            "SMTP",
            "Eclipse",
            "Наследование",
            "Сетевой анализ",
        };
        private String[] answer2 = new string[10] {
            "PHP",
            "Итеративная модель ",
            "Jenkins ",
            "Дебаггинг",
            "Интеграционное тестирование ",
            "Линейный поиск ",
            "FTP",
            "Visual Studio Code ",
            "Полиморфизм ",
            "Прототипирование",
        };
        private String[] answer3 = new string[10] {
            "JavaScript",
            "Agile ",
            "Git",
            "Нормализация",
            "Модульное тестирование",
            "Двоичный поиск",
            "HTTP",
            "PyCharm ",
            "Инкапсуляция ",
            "Рефакторинг",
        };
        public Topic2Test3()
        {
            InitializeComponent();
            label3.Hide();
            groupBox1.Hide();
            button2.Hide();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            label2.Text = (n + 1).ToString() + "/10";
            Button1.Hide();
            label3.Visible = true;
            label3.Text = questions[n];
            radioButton1.Text = answer1[n];
            radioButton2.Text = answer2[n];
            radioButton3.Text = answer3[n];
            groupBox1.Visible = true;
            button2.Visible = true;
            n++;
        }
        private void ShowAnswer(int p)
        {
            label2.Hide();
            groupBox1.Hide();
            button2.Hide();
            if (points <= 5)
            {
                label3.Text = $"Ваш результат: {points} баллов\n\n" +
                "Начальный уровень знаний, требуется дополнительное обучение.";
            }
            else if (points >= 6 && points <= 10)
            {
                label3.Text = $"Ваш результат: {points} баллов\n\n" +
                "Средний уровень знаний, возможно,\n"+ "потребуется практика и углубленное изучение.\n";
            }
            else if (points >= 11 && points <= 15)
            {
                label3.Text = $"Ваш результат: {points} баллов\n" +
                "Хороший уровень знаний,\n"+ "достойный для большинства позиций в айти-сфере.\n";
            }
            else if (points >= 16 && points <= 20)
            {
                label3.Text = $"Ваш результат: {points} баллов\n" +
                "Отличный уровень знаний, подходящий для более сложных\n"+ "и ответственных ролей в айти-сфере.\n";
            }
        }
        private void NextQuestion(int num)
        {
            if (num < 10)
            {
                label2.Text = (n + 1).ToString() + "/10";
                label3.Text = questions[n];
                radioButton1.Text = answer1[n];
                radioButton2.Text = answer2[n];
                radioButton3.Text = answer3[n];
            }
            if (num == 10)
                ShowAnswer(points);
            n++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked)
            {
                MessageBox.Show("Выберите один из вариантов ответа");
                return;
            }
            if (radioButton1.Checked)
            {
                NextQuestion(n);
            }
            else if (radioButton2.Checked)
            {
                points++;
                NextQuestion(n);
            }
            else if (radioButton3.Checked)
            {
                points = points + 2;
                NextQuestion(n);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainWindow main = new MainWindow();
            main.Show();
        }

    }
}
