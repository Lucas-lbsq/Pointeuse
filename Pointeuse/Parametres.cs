using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Siticone.Desktop.UI.WinForms;

namespace Pointeuse
{
    public partial class Parametres : Form
    {

        bool sidebarExpand;
       

        public Parametres()
        {
            InitializeComponent();
        }
        public Parametres(Color fore, Color back):this()
        {
            ColorChange(fore);
            BackColorChange(back);
        }

        //Changement de couleur SideBar
        void ColorChange(Color color)
        {
            sidebar.BackColor = button2.BackColor = button3.BackColor = button4.BackColor 
                              = button5.BackColor = button6.BackColor = button7.BackColor = button8.BackColor =
                sidebar.ForeColor = color;
            foreach (var btn in sidebar.Controls.OfType<SiticoneRadioButton>())
                btn.BackColor = color;
        }
        //Prend la couleur du texte du boutton
        private void btn_CheckedChanged(object sender, EventArgs e)
        {
            SiticoneRadioButton button = (SiticoneRadioButton)sender;
            ColorChange(button.ForeColor);
        }

        //Changement de coleur du fond d'écran
        void BackColorChange(Color color)
        {
            this.BackColor = color;
            foreach (var btn in sidebar.Controls.OfType<SiticoneRadioButton>())
                btn.BackColor = color;
        }
        //Prend la couleur du texte du boutton
        private void Backbtn_CheckedChanged(object sender, EventArgs e)
        {
            SiticoneRadioButton button = (SiticoneRadioButton)sender;
            BackColorChange(button.ForeColor);
        }

        #region SideBar
        //Configurer la SideBar
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
                foreach (var btn in sidebar.Controls.OfType<SiticoneRadioButton>())
                    btn.Text = string.Empty;
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

        //Démarrer la SideBar
        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }
        #endregion

        #region Redirection boutton
        //Button Accueil
        private void button8_Click(object sender, EventArgs e)
        {
            Accueil accueil = new Accueil(sidebar.BackColor, this.BackColor, this) ;
            accueil.Show();
            this.Hide();
        }

        //Button Pointages
        private void button2_Click(object sender, EventArgs e)
        {
            Pointages pointages = new Pointages();
            pointages.Show();
            this.Hide();
        }

        //Button Historique
        private void button3_Click(object sender, EventArgs e)
        {
            Historique historique = new Historique();
            historique.Show();
            this.Hide();
        }

        //Button Statistique
        private void button4_Click(object sender, EventArgs e)
        {
            Statistique statistique = new Statistique();
            statistique.Show();
            this.Hide();
        }

        //Button Compte
        private void button5_Click(object sender, EventArgs e)
        {
            Compte compte = new Compte();
            compte.Show();
            this.Hide();
        }

        //Button Info
        private void button7_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            info.Show();
            this.Hide();
        }
        #endregion
    }
}
