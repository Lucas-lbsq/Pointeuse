using System.Data;
using System.Data.Common;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using Pointeuse.db_contexts;
using Pointeuse.Entités;
using Entités = Pointeuse.Entités;

namespace Pointeuse
{
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
        }

        //Champ mot de passe : ●
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_effacer.Checked)
            {
                textBox_password.PasswordChar = '\0';
            }
            else
            {
                textBox_password.PasswordChar = '●';
            }
        }

        //Button Effacer
        private void button2_Click(object sender, EventArgs e)
        {
            textBox_indentifiant.Text = "";
            textBox_password.Text = "";
            textBox_indentifiant.Focus();
        }

        //Redirection vers Inscription
        private void label6_Click(object sender, EventArgs e)
        {
            Inscription inscription = new Inscription();
            inscription.Show();
            this.Hide();
        }

        private void button_connecter_Click(object sender, EventArgs e, Entités.User user)
        {
            //Ouvrir connexion
            DbConnection _connexion = new SqliteConnection("Data Source=../../../Pointeuse.db");
            _connexion.Open();

            //Utiliser sqlLite
            DbContextOptions<PointeuseContext> _contextOptions = new DbContextOptionsBuilder<PointeuseContext>().UseSqlite(_connexion).Options;

            //Prendre la page de context
            PointeuseContext context = new PointeuseContext(_contextOptions);
            context.Database.EnsureCreated();

            var userConnexion = context.User.Where(u => u.Identifiant == user.Identifiant && u.Password == user.Password).First();
            if (userConnexion != null)
            {
                // On accepte la connexion
                MessageBox.Show("Ok, vous êtes inscrit", "Bravo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                //Connexion refusée
            }
        }
        private bool userTenteConnexion(PointeuseContext context, Entités.User user)
        {
            var userConnexion = context.User.Where(u => u.Identifiant == user.Identifiant && u.Password == user.Password).First();
            if (userConnexion != null)
            {
                // On accepte la connexion
                MessageBox.Show("Ok, vous êtes inscrit", "Bravo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                //Connexion refusée
                return false;
            }
        }
    }
}
