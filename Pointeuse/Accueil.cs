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
using System.Data.Common;
using Microsoft.Data.Sqlite;
using Pointeuse.db_contexts;
using Microsoft.EntityFrameworkCore;

namespace Pointeuse
{

    public partial class Accueil : Form
    {
        private readonly PointeuseContext _context;
        bool sidebarExpand;
        Form gFormAppelante;

        public Accueil()
        {

            ////Ouvrir connexion
            DbConnection _connexion = new SqliteConnection("Data Source=../../../Pointeuse.db");
            _connexion.Open();

            //Utiliser sqlLite
            DbContextOptions<PointeuseContext> _contextOptions = new DbContextOptionsBuilder<PointeuseContext>().UseSqlite(_connexion).Options;

            //Prendre la page de context
            _context = new PointeuseContext(_contextOptions, true);
            _context.Database.EnsureCreated();
            InitializeComponent();
        }

        
        private void Accueil_Load(object sender, EventArgs e)
        {
            timer_heure.Start();
            label_date.Text = DateTime.Now.ToLongDateString();
            label_heure.Text = DateTime.Now.ToLongDateString();
        }

        #region SideBar
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
        #endregion

        #region Redirection boutton
        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
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

        private void button7_Click(object sender, EventArgs e)
        {
            Info info = new Info(_context);
            info.Show();
            this.Hide();
        }
        #endregion

        private void timer_label_Tick(object sender, EventArgs e)
        {
            label_heure.Text = DateTime.Now.ToLongTimeString();
            timer_heure.Start();
        }

     }
}