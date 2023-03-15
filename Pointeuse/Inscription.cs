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

        //Champ password caché
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

        //Boutton Effacer
        private void button2_Click(object sender, EventArgs e)
        {
            textBox_prenom.Text = "";
            textBox_nom.Text = "";
            textBox_identifiant.Text = "";
            textBox_password.Text = "";
            textBox_confirmpassword.Text = "";
            textBox_nom.Focus();
        }

        //Redirection vers Connexion
        private void label6_Click(object sender, EventArgs e)
        {
            Connexion connexion = new Connexion();
            connexion.Show();
            this.Hide();
        }

        private void button_inscription_Click(object sender, EventArgs e)
        {
            if (textBox_password.Text.Length <= 5)
            {
                MessageBox.Show("Le Mot de passe est trop petit !", "Mot de passe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (textBox_password.Text != textBox_confirmpassword.Text)
            {
                MessageBox.Show("Mot de passe différent", "Mot de passe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ////Ouvrir connexion
                DbConnection _connexion = new SqliteConnection("Data Source=../../../Pointeuse.db");
                _connexion.Open();

                //Utiliser sqlLite
                DbContextOptions<PointeuseContext> _contextOptions = new DbContextOptionsBuilder<PointeuseContext>().UseSqlite(_connexion).Options;

                //Prendre la page de context
                PointeuseContext context = new PointeuseContext(_contextOptions, true);
                context.Database.EnsureCreated();

                //Attribut les valeurs dans la DB
                User utilisateurInscription = new User()
                {
                    Nom = textBox_nom.Text,
                    Prenom = textBox_prenom.Text,
                    Identifiant = textBox_identifiant.Text,
                    Password = textBox_password.Text,
                    Service = ""
                };
                if (userTenteInscription(context, utilisateurInscription))
                {
                    context.User.Add(utilisateurInscription);
                    if (context.SaveChanges() > 0)
                    {
                        MessageBox.Show("Ok, vous êtes inscrit", "Bravo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Connexion connexion = new Connexion();
                        connexion.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Une erreur est survenue", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Utilisateur déjà existant", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                context.SaveChanges();
            }         
            
        }
        private bool userTenteInscription(PointeuseContext context, User user)
        {
            var userConnexion = context.User.Where(u => u.Identifiant == user.Identifiant).FirstOrDefault();
            if (userConnexion != null)
            {
                //Utilisateur avec cet identifiant déjà existant donc pas d'inscription possible
                MessageBox.Show("Utilisateur déjà existant", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                //Utilisateur avec cet identifiant inexistant, donc on valide l'inscription
                MessageBox.Show("Ok, vous êtes inscrit", "Bravo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
        }
    }
}



