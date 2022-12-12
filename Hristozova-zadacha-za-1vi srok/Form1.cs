namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Ivan");
            comboBox1.Items.Add("Dimitar");
            comboBox1.Items.Add("Goshka");
            comboBox1.Items.Add("Nikoleta");

            comboBox2.Items.Add("Ivanov");
            comboBox2.Items.Add("Dimitrov");
            comboBox2.Items.Add("Georgieva");
            comboBox2.Items.Add("Nikolova");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string egn = textBox1.Text;
            try
            {
                if ((comboBox2.SelectedItem.ToString().EndsWith("a")) || int.Parse(egn.Substring(egn.Length - 1)) % 2 == 0)
                {
                    MessageBox.Show("Jena");
                }
                else if (!(comboBox2.SelectedItem.ToString().EndsWith("a")) || int.Parse(egn.Substring(egn.Length - 1)) % 2 == 1)
                {
                    MessageBox.Show("Muj");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greshka pri populvaneto na poletata, opitaite pak {ex.Message}");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}