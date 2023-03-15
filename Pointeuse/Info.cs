using System.Globalization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Pointeuse.db_contexts;

namespace Pointeuse
{
    public partial class Info : Form
    {
        private readonly PointeuseContext _context;
        bool sidebarExpand;
        Form gFormAppelante;

        public Info(PointeuseContext context)
        {
            this._context = context;
            InitializeComponent();

        }

        public Info()
        {
            InitializeComponent();

        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            //Bouger la SideBar

            if (sidebarExpand)
            {
                //if sidebar is expand, minimize
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Accueil accueil = new Accueil();
            accueil.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pointages pointages = new Pointages();
            pointages.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Historique historique = new Historique();
            historique.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Statistique statistique = new Statistique();
            statistique.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Compte compte = new Compte(_context);
            compte.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Parametres parametres = new Parametres();
            parametres.Show();
            this.Hide();
        }
    }
}
