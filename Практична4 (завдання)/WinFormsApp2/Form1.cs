namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CountryMedal new_country;
            if (crainaBox.Text == "")
            {
                MessageBox.Show("������ �����");
            }
            if (kilkistsportBox.Text == "")
            {
                MessageBox.Show("������ ������� ����������");
            }
            if (zolotoBox.Text == "")
            {
                MessageBox.Show("������ ������� ������� �������");
            }
            if (sribloBox.Text == "")
            {
                MessageBox.Show("������ ������� ������ �������");
            }
            if (bronzaBox.Text == "")
            {
                MessageBox.Show("������ ������� ��������� �������");
            }
            new_country = new CountryMedal(crainaBox.Text, Convert.ToInt32(kilkistsportBox.Text), Convert.ToInt32(zolotoBox.Text), Convert.ToInt32(sribloBox.Text), Convert.ToInt32(bronzaBox.Text));
            resultBox.Text = new_country.GetInformation();
        }
    }
}
