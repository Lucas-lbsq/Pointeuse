namespace Pointeuse
{
    public partial class Inscription : Form
    {
        public Inscription()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_affficher.Checked)
            {
                textBox_password.PasswordChar = '\0';
                textBox_confirmpassword.PasswordChar = '\0';
            }
            else
            {
                textBox_password.PasswordChar = '●';
                textBox_confirmpassword.PasswordChar = '●';
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            textBox_prenom.Text = "";
            textBox_nom.Text = "";
            textBox_identifiant.Text = "";
            textBox_password.Text = "";
            textBox_confirmpassword.Text = "";
            textBox_nom.Focus();
        }
        private void label6_Click(object sender, EventArgs e)
        {
            Connexion connexion = new Connexion();
            connexion.Show();
            this.Hide();
        }

        private void button_inscription_Click(object sender, EventArgs e)
        {

        }
    }
}
