using System.Drawing.Drawing2D;

namespace тема2
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        public class RoundButton : Button
        {
            GraphicsPath GetRoundPath(RectangleF Rect, int radius)
            {
                float r2 = radius / 2f;
                GraphicsPath GraphPath = new GraphicsPath();

                GraphPath.AddArc(Rect.X, Rect.Y, radius, radius, 180, 90);
                GraphPath.AddLine(Rect.X + r2, Rect.Y, Rect.Width - r2, Rect.Y);
                GraphPath.AddArc(Rect.X + Rect.Width - radius, Rect.Y, radius, radius, 270, 90);
                GraphPath.AddLine(Rect.Width, Rect.Y + r2, Rect.Width, Rect.Height - r2);
                GraphPath.AddArc(Rect.X + Rect.Width - radius,
                                    Rect.Y + Rect.Height - radius, radius, radius, 0, 90);
                GraphPath.AddLine(Rect.Width - r2, Rect.Height, Rect.X + r2, Rect.Height);
                GraphPath.AddArc(Rect.X, Rect.Y + Rect.Height - radius, radius, radius, 90, 90);
                GraphPath.AddLine(Rect.X, Rect.Height - r2, Rect.X, Rect.Y + r2);

                GraphPath.CloseFigure();
                return GraphPath;
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);
                RectangleF Rect = new RectangleF(0, 0, this.Width, this.Height);
                GraphicsPath GraphPath = GetRoundPath(Rect, 50);

                this.Region = new Region(GraphPath);
                using (Pen pen = new Pen(Color.White, 2.95f))
                {
                    pen.Alignment = PenAlignment.Inset;
                    e.Graphics.DrawPath(pen, GraphPath);
                }
            }
        }
        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttTest1 = new RoundButton();
            buttTest2 = new RoundButton();
            buttTest4 = new RoundButton();
            buttText5 = new RoundButton();
            buttTest3 = new RoundButton();
            buttTest7 = new RoundButton();
            buttTest6 = new RoundButton();
            SuspendLayout();
            // 
            // buttTest1
            // 
            buttTest1.BackColor = Color.FromArgb(165, 242, 252);
            buttTest1.Location = new Point(259, 146);
            buttTest1.Name = "buttTest1";
            buttTest1.Size = new Size(562, 38);
            buttTest1.TabIndex = 0;
            buttTest1.Text = "Делегирование полномочий и принятие решений";
            buttTest1.UseVisualStyleBackColor = false;
            buttTest1.Click += button1_Click;
            // 
            // buttTest2
            // 
            buttTest2.BackColor = Color.FromArgb(165, 242, 252);
            buttTest2.Location = new Point(259, 206);
            buttTest2.Name = "buttTest2";
            buttTest2.Size = new Size(562, 38);
            buttTest2.TabIndex = 1;
            buttTest2.Text = "Отбор персонала";
            buttTest2.UseVisualStyleBackColor = false;
            buttTest2.Click += roundButton1_Click;
            // 
            // buttTest4
            // 
            buttTest4.BackColor = Color.FromArgb(165, 242, 252);
            buttTest4.Location = new Point(259, 333);
            buttTest4.Name = "buttTest4";
            buttTest4.Size = new Size(562, 38);
            buttTest4.TabIndex = 2;
            buttTest4.Text = "Мотивация персонала";
            buttTest4.UseVisualStyleBackColor = false;
            // 
            // buttText5
            // 
            buttText5.BackColor = Color.FromArgb(165, 242, 252);
            buttText5.Location = new Point(259, 393);
            buttText5.Name = "buttText5";
            buttText5.Size = new Size(562, 38);
            buttText5.TabIndex = 3;
            buttText5.Text = "Системы компенсации и стимулирования персонала";
            buttText5.UseVisualStyleBackColor = false;
            // 
            // buttTest3
            // 
            buttTest3.BackColor = Color.FromArgb(165, 242, 252);
            buttTest3.Location = new Point(259, 268);
            buttTest3.Name = "buttTest3";
            buttTest3.Size = new Size(562, 38);
            buttTest3.TabIndex = 4;
            buttTest3.Text = "Адаптация сотрудников";
            buttTest3.UseVisualStyleBackColor = false;
            // 
            // buttTest7
            // 
            buttTest7.BackColor = Color.FromArgb(165, 242, 252);
            buttTest7.Location = new Point(259, 516);
            buttTest7.Name = "buttTest7";
            buttTest7.Size = new Size(562, 38);
            buttTest7.TabIndex = 5;
            buttTest7.Text = "Создание эффективной команды";
            buttTest7.UseVisualStyleBackColor = false;
            // 
            // buttTest6
            // 
            buttTest6.BackColor = Color.FromArgb(165, 242, 252);
            buttTest6.Location = new Point(259, 454);
            buttTest6.Name = "buttTest6";
            buttTest6.Size = new Size(562, 38);
            buttTest6.TabIndex = 6;
            buttTest6.Text = "Управление проблемными сотрудниками";
            buttTest6.UseVisualStyleBackColor = false;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(231, 248, 243);
            ClientSize = new Size(1067, 670);
            Controls.Add(buttTest6);
            Controls.Add(buttTest7);
            Controls.Add(buttTest3);
            Controls.Add(buttText5);
            Controls.Add(buttTest4);
            Controls.Add(buttTest2);
            Controls.Add(buttTest1);
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainWindow";
            ResumeLayout(false);
        }

        #endregion

        private RoundButton buttTest1;
        private RoundButton buttTest2;
        private RoundButton buttTest4;
        private RoundButton buttText5;
        private RoundButton buttTest3;
        private RoundButton buttTest7;
        private RoundButton buttTest6;
    }
}
