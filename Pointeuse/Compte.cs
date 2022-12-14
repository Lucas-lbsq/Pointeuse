using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pointeuse
{
    public partial class Compte : Form
    {
        public Compte()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Inscription inscription = new Inscription();
            inscription.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Connexion connexion = new Connexion();
            connexion.Show();
            this.Hide();
        }
    }
}
