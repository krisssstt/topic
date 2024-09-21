using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using тема2;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace тема_1
{
    public partial class Test3 : Form
    {
        private int n = 0;
        private int points = 0;
        private String[] questions = new string[10] {
                "Что такое делегирование полномочий?",
                "Какой из следующих факторов не влияет на делегирование?",
                "Какой из этих навыков особенно важен для успешного\n"+" делегирования?",
                "Какой этап не входит в процесс принятия решений?",
                "Какой из следующих методов можно использовать\n" +"для оценки альтернативных решений?  ",
                "Какой из следующих вариантов является\n"+" преимуществом делегирования?",
                "Что может стать причиной неудачи в делегировании полномочий?",
                "Как называется процесс, при котором руководитель проверяет\n"+ "выполнение задания после делегирования?",
                "Что из следующего не является признаком\n"+" эффективного делегирования?",
                "Какая из приведённых стратегий может помочь\n"+" в принятии сложных решений?"};
        private String[] answer1 = new string[10] {
            "Отказ от выполнения обязанностей  ",
            "Уровень доверия к подчинённым",
            "Умение избегать общения",
            "Определение проблемы",
            "Демонстрация силы",
            "Увеличение рабочей нагрузки для руководителя",
            "Чёткие инструкции",
            "Процесс планирования",
            "Сотрудник понимает свои обязанности",
            "Подход «все или ничего»",
        };
        private String[] answer2 = new string[10] {
            "Принятие судьбоносных решений",
            "Степень сложности задачи",
            "Умение контролировать всех сотрудников",
            "Генерация альтернатив ",
            "Эмоциональное восприятие",
            "Замедление принятия решений",
            "Доверие к команде ",
            "Оценка эффективности ",
            "Сотрудник чувствует себя уверенным в своих действиях",
            "Игнорирование собственных эмоций",
        };
        private String[] answer3 = new string[10] {
            "Передача задач другим сотрудникам",
            "Количество сотрудников в компании ",
            "Умение ясно формулировать задачи",
            "Игнорирование последствий",
            "SWOT-анализ",
            "Повышение мотивации подчинённых",
            "Неопределённость в задачах",
            "Контроль",
            "Сотрудник постоянно обращается за консультацией",
            "Использование коллективного мнения",
        };
        public Test3()
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
            if (points <= 6)
            {
                label3.Text = $"Ваш результат: {points} баллов\n" +
                "Рекомендации: Вы имеете начальное представление о\n" +
                "делегировании и принятии решений. Рекомендуется изучить\n" +
                "основные концепты и подходы к делегированию. Прочитайте\n" +
                "книги или пройдите курсы по управлению, чтобы углубить \n" + "свои знания.";
            }
            else if (points >= 7 && points <= 12)
            {
                label3.Text = $"Ваш результат: {points} баллов\n" +
                "Рекомендации: У вас достаточно понимания тематики, однако\n" +
                "есть области, требующие улучшения. Сфокусируйтесь на\n" +
                "практике делегирования и принимайте участие в обсуждениях\n" +
                "по принятию решений в команде. Попробуйте применять\n" +
                "полученные знания в реальных ситуациях.\n";
            }
            else if (points >= 13 && points <= 18)
            {
                label3.Text = $"Ваш результат: {points} баллов\n" +
                "Рекомендации: Вы обладаете хорошими знаниями о\n" +
                "делегировании и процессе принятия решений. Чтобы еще\n" +
                "больше улучшить свои навыки, начните применять их на\n" +
                "практике и работайте над созданием более эффективных\n" + "команд.";
            }
            else if (points >= 19 && points <= 24)
            {
                label3.Text = $"Ваш результат: {points} баллов\n" +
                "Рекомендации: Вы эксперт в области делегирования и \n" +
                "принятия решений! Продолжайте развивать свои навыки и\n" +
                "делитесь знаниями с другими. Рассмотрите возможность\n" +
                "наставничества новых сотрудников или участия в тренингах для\n" + "развития управленческих навыков.\n";
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
