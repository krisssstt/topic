﻿using System;
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
    public partial class Topic2Test1 : Form
    {
        private int n = 0;
        private int points = 0;
        private String[] questions = new string[10] {
                "Что такое Agile?",
                "Что обозначает термин 'MVC' в веб-разработке?",
                "Что такое Git?",
                "Какова основная цель использования Docker?",
                "Что такое REST API?",
                "Какой из этих языков считается объектно-ориентированным?",
                "Что такое CI/CD?",
                "Какова основная функция кэша?",
                "Что обозначает принцип DRY?",
                "Что такое SQL?"};
        private String[] answer1 = new string[10] {
            "Это методология, предназначенная для улучшения\n"+" работы аппаратного обеспечения",
            "Мобильная версия сайта.",
            "Программа для автоматизации тестирования кода.",
            "Создание виртуальных машин. ",
            "Язык программирования для работы с API.",
            "SQL.",
            "Это среда для разработки программного обеспечения.",
            "Защита данных от несанкционированного доступа.",
            "'Don't Run Yourself' — оптимизация\n"+" производительности программ",
            "Это библиотека для работы\n"+" с базами данных в Python.",
        };
        private String[] answer2 = new string[10] {
            "Это набор принципов управления проектами,\n"+"который включает гибкие подходы к разработке. ",
            "Методы валидации данных для веб-форм. ",
            "Язык программирования для работы с данными.",
            "Упрощение разработки мобильных приложений.",
            "Протокол передачи данных между веб-сервисами.",
            "HTML.",
            "Это система для управления версиями кода.",
            "Хранение данных для экономии памяти.",
            "'Define, Repeat, Yield' — цикл обработки\n"+" данных в многопоточности. ",
            "Это программа для создания баз данных.",
        };
        private String[] answer3 = new string[10] {
            "Это подход к разработке программного обеспечения, основанный\n"+" на гибкости, итерациях и тесном взаимодействии с клиентом.",
            "Модель, вид и контроллер, представляющие архитектурный\n"+"паттерн для создания приложений.",
            "Система управления версиями программного обеспечения.",
            "Изоляция приложений с использованием контейнеров\n" + "для более легкой развертки и масштабирования. ",
            "Архитектурный стиль, использующий HTTP для взаимодействия\n" +"между системами.",
            "Python",
            "Это процессы для постоянной интеграции\n"+" и непрерывной доставки кода. ",
            "Ускорение доступа к часто используемым данным,\n"+" временно храня их в памяти. ",
            "'Don't Repeat Yourself' — избегание дублирования кода\n"+"для улучшения читаемости и поддерживаемости. ",
            "Это язык программирования для работы с базами данных.",
        };
        public Topic2Test1()
        {
            InitializeComponent();
            label3.Hide();
            groupBox1.Hide();
            button2.Hide();
            button3.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = (n + 1).ToString() + "/10";
            button1.Hide();
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
            if (points <=5)
            {
                label3.Text = $"Ваш результат: {points} баллов\n\n" +
                "Вам необходимы базовые знания и навыки в IT-сфере.";
            }
            else if (points>=6 && points <=12)
            {
                label3.Text = $"Ваш результат: {points} баллов\n\n" +
                "Имеются частичные знания,\n"+"но требуется больше практики и обучения.\n";
            }
            else if(points >=13 && points <=16)
            {
                label3.Text = $"Ваш результат: {points} баллов\n\n" +
                "Достаточные знания для старта,\n"+"можно развивать навыки в конкретной области.";
            }
            else if(17<=points&& points<=20)
            {
                label3.Text = $"Ваш результат: {points} баллов\n\n" +
                    "Отличный результат, подходите для работы в IT-сфере!";
            }
            button3.Visible = true;
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Topic2Test2 test2 = new Topic2Test2();
            test2.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainWindow main = new MainWindow();
            main.Show();
        }
        
    }
}
