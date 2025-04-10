using System.Security.Cryptography.X509Certificates;

namespace Практичне4
{
    public partial class frmClasses : Form
    {
        public frmClasses()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            Person new_person;
            if (txtName.Text == "")
            {
                MessageBox.Show("Введіть ім'я");
            }
            if (txtAge.Text != "")
            {
                if (txtProf.Text != "")
                {
                    new_person = new Person(txtName.Text, Convert.ToInt32(txtAge.Text), txtProf.Text);
                }
                else
                {
                    new_person = new Person(txtName.Text, Convert.ToInt32(txtAge.Text));
                }
            }
            else
            {
                if (txtProf.Text != "")
                {
                    new_person = new Person(txtName.Text, 0, txtProf.Text);
                }
                else
                {
                    new_person = new Person(txtName.Text, 0);
                }
            }
            txtResult.Text += new_person.GetInformation();

        }
        private void txtResult_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProf_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
