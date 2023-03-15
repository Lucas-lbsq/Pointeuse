namespace Pointeuse
{
    public partial class Pointages : Form
    {
        bool sidebarExpand;
        public Pointages()
        {
            InitializeComponent();
        }
        private void Pointages_Load(object sender, EventArgs e)
        {

            timer_ProgressBar.Interval = 100; //1 secondes

            timer_ProgressBar.Start();
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

        private void button_matin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bonne matinée, le pointage a bien été pris en compte", "Pointage OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_midi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bon appétit, le pointage a bien été pris en compte", "Pointage OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_apres_midi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bonne après midi, le pointage a bien été pris en compte", "Pointage OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_soir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bonne soirée, le pointage a bien été pris en compte", "Pointage OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void timer_ProgressBar_Tick(object sender, EventArgs e)
        {

            DateTime heureActuelle = DateTime.Now;
            progressBar_temp.Style = ProgressBarStyle.Continuous;
            label_heure.Text = heureActuelle.ToString("HH:mm:ss");

            int HeureDebut = 12;
            int HeureFin = 13;

            if (heureActuelle.Hour >= HeureDebut && heureActuelle.Hour < HeureFin)
            {
                // Calculer le pourcentage de progression en fonction de l'heure actuelle
                int minutesTotal = (HeureFin - HeureDebut) * 60;
                int minutesEcoulées = (heureActuelle.Hour - HeureDebut) * 60 + heureActuelle.Minute;
                int pourcentageProgression = (int)((double)minutesEcoulées / minutesTotal * 100);
                
                
                // Mettre à jour la ProgressBar
                progressBar_temp.Value = pourcentageProgression;

                // Mettre à jour la position du Label
                int labelLeft = progressBar_temp.Left + (progressBar_temp.Width - label_heure.Width) * progressBar_temp.Value / progressBar_temp.Maximum;
                label_heure.Left = labelLeft;
            }

        }

        private void progressBar_temp_Click(object sender, EventArgs e)
        {

        }

    }
}
