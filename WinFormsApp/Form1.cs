using System.Diagnostics.Metrics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Top -= 10;
            this.Top -= 10;
            DialogResult result = MessageBox.Show(
                "Felfelé mész?",
                "UP",
                MessageBoxButtons.AbortRetryIgnore,
                MessageBoxIcon.Error
            );
            textBox1.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Left -= 10;
            this.Left -= 10;
            DialogResult result = MessageBox.Show(
                "Balra mész?",
                "UP",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            textBox1.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Top += 10;
            this.Top += 10;
            DialogResult result = MessageBox.Show(
                "Lefele mész?",
                "UP",
                MessageBoxButtons.RetryCancel,
                MessageBoxIcon.Warning
            );
            textBox1.Text = result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Left += 10;
            this.Left += 10;
            DialogResult result = MessageBox.Show(
                "Jobbra mész?",
                "UP",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information
            );
            textBox1.Text = result.ToString();
        }
        int counter = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = DateTime.Now.ToString("HH:mm:ss");
            string text = "Lejart";
            textBox1.Text = text;
            this.BackColor = Color.FromArgb(
                rnd.Next(256),
                rnd.Next(256),
                rnd.Next(256)
            );
            counter++;
            textBox1.Text = counter.ToString();

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int interval;

            if (int.TryParse(textBox2.Text, out interval))
            {
                timer1.Interval = interval;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
