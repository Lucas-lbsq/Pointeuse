using System.Data.Common;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Pointeuse.db_contexts;
using Pointeuse.Entités;

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

            DbConnection _connexion = new SqliteConnection("Data Source=../../../Pointeuse.db");
            _connexion.Open();

            DbContextOptions<PointeuseContext> _contextOptions = new DbContextOptionsBuilder<PointeuseContext>().UseSqlite(_connexion).Options;

            PointeuseContext context = new PointeuseContext(_contextOptions);
            context.Database.EnsureCreated();

            Users utilisateurInscription = new Users()
            {
                Nom = textBox_nom.Text,
                Prenom = textBox_prenom.Text,
                Password = textBox_password.Text,
                Identifiant = textBox_identifiant.Text,
                Service = ""
            };
            var users = context.Users.ToList();
            var booll = context.Users.Add(utilisateurInscription);
            Console.Write(booll);
            context.SaveChanges();
        }
    }
}
