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
using Siticone.Desktop.UI.WinForms;


namespace Pointeuse
{

    public partial class Accueil : Form
    {
        bool sidebarExpand;
        Form gFormAppelante;

        public Accueil()
        {
            InitializeComponent();
        }
        public Accueil(Color fore, Color back, Form formAppelante) : this()
        {
            ColorChange(fore);
            BackColorChange(back);
            gFormAppelante = formAppelante;
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
            Compte compte = new Compte();
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
            Info info = new Info();
            info.Show();
            this.Hide();
        }
        #endregion

        private void timer_label_Tick(object sender, EventArgs e)
        {
            label_heure.Text = DateTime.Now.ToLongTimeString();
            timer_heure.Start();
        }

        #region
        //commentaire
        void ColorChange(Color color)
        {
            sidebar.BackColor = button2.BackColor = button3.BackColor = button4.BackColor
                              = button5.BackColor = button6.BackColor = button7.BackColor = button8.BackColor =
                sidebar.ForeColor = color;
            foreach (var btn in sidebar.Controls.OfType<SiticoneRadioButton>())
                btn.BackColor = color;
        }

        //Changement de coleur du fond d'écran
        void BackColorChange(Color color)
        {
            this.BackColor = color;
            foreach (var btn in sidebar.Controls.OfType<SiticoneRadioButton>())
                btn.BackColor = color;
        }

        private void Accueil_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.gFormAppelante.Show();
        }
        #endregion
    }
}