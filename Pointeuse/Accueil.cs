using System.Globalization;

namespace Pointeuse
{
    public partial class Accueil : Form
    {
        bool sidebarExpand;

        public Accueil()
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

        private void Accueil_Load(object sender, EventArgs e)
        {
            timer_heure.Start();
            label_date.Text = DateTime.Now.ToLongDateString();
            label_heure.Text = DateTime.Now.ToLongDateString();
        }

        private void timer_label_Tick(object sender, EventArgs e)
        {
            label_heure.Text = DateTime.Now.ToLongTimeString();
            timer_heure.Start();
        }
    }
}