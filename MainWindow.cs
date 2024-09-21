using System.Windows.Forms.Design;
using тема_1;

namespace тема2
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Topic2Test1 topic2 = new Topic2Test1();
            topic2.Show();
        }
    }
}
