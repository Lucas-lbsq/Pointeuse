using Pointeuse.Class;

namespace Pointeuse
{
    partial class Pointages
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pointages));
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox_pointages = new System.Windows.Forms.GroupBox();
            this.groupBox_soir = new System.Windows.Forms.GroupBox();
            this.label_soir = new System.Windows.Forms.Label();
            this.button_soir = new System.Windows.Forms.Button();
            this.groupBox_midi = new System.Windows.Forms.GroupBox();
            this.label_midi = new System.Windows.Forms.Label();
            this.button_midi = new System.Windows.Forms.Button();
            this.groupBox_apres_midi = new System.Windows.Forms.GroupBox();
            this.label_apres_midi = new System.Windows.Forms.Label();
            this.button_apres_midi = new System.Windows.Forms.Button();
            this.groupBox_matin = new System.Windows.Forms.GroupBox();
            this.label_matin = new System.Windows.Forms.Label();
            this.button_matin = new System.Windows.Forms.Button();
            this.progressBar_temp = new Pointeuse.Class.NewProgressBar();
            this.timer_ProgressBar = new System.Windows.Forms.Timer(this.components);
            this.label_heure = new System.Windows.Forms.Label();
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.groupBox_pointages.SuspendLayout();
            this.groupBox_soir.SuspendLayout();
            this.groupBox_midi.SuspendLayout();
            this.groupBox_apres_midi.SuspendLayout();
            this.groupBox_matin.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.Controls.Add(this.panel5);
            this.sidebar.Controls.Add(this.panel6);
            this.sidebar.Controls.Add(this.panel7);
            this.sidebar.Controls.Add(this.panel8);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sidebar.MaximumSize = new System.Drawing.Size(191, 657);
            this.sidebar.MinimumSize = new System.Drawing.Size(67, 657);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(67, 657);
            this.sidebar.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.menuButton);
            this.panel1.Location = new System.Drawing.Point(4, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 141);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(74, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
            // 
            // menuButton
            // 
            this.menuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton.Image = global::Pointeuse.Properties.Resources.icons8_menu_32;
            this.menuButton.Location = new System.Drawing.Point(10, 44);
            this.menuButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(47, 50);
            this.menuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menuButton.TabIndex = 0;
            this.menuButton.TabStop = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(4, 150);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 58);
            this.panel2.TabIndex = 7;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Image = global::Pointeuse.Properties.Resources.icons8_home_32;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(-25, -15);
            this.button8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button8.Name = "button8";
            this.button8.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button8.Size = new System.Drawing.Size(312, 81);
            this.button8.TabIndex = 7;
            this.button8.Text = "            Accueil";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-22, -15);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(312, 81);
            this.button1.TabIndex = 6;
            this.button1.Text = "            Accueil";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2);
            this.panel3.Location = new System.Drawing.Point(4, 214);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(270, 58);
            this.panel3.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::Pointeuse.Properties.Resources.icons8_clock_32;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(-25, -15);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(312, 81);
            this.button2.TabIndex = 6;
            this.button2.Text = "            Pointages";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button3);
            this.panel4.Location = new System.Drawing.Point(4, 278);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(270, 58);
            this.panel4.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::Pointeuse.Properties.Resources.icons8_time_machine_32;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(-25, -15);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button3.Size = new System.Drawing.Size(312, 81);
            this.button3.TabIndex = 6;
            this.button3.Text = "            Historique";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button4);
            this.panel5.Location = new System.Drawing.Point(4, 342);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(270, 58);
            this.panel5.TabIndex = 10;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::Pointeuse.Properties.Resources.icons8_combo_chart_32;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(-25, -15);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button4.Size = new System.Drawing.Size(312, 81);
            this.button4.TabIndex = 6;
            this.button4.Text = "            Statistique";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button5);
            this.panel6.Location = new System.Drawing.Point(4, 406);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(270, 58);
            this.panel6.TabIndex = 11;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = global::Pointeuse.Properties.Resources.icons8_account_32;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(-25, -15);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button5.Size = new System.Drawing.Size(312, 81);
            this.button5.TabIndex = 6;
            this.button5.Text = "            Compte";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.button6);
            this.panel7.Location = new System.Drawing.Point(4, 470);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(270, 58);
            this.panel7.TabIndex = 12;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = global::Pointeuse.Properties.Resources.icons8_settings_32;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(-25, -15);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button6.Size = new System.Drawing.Size(312, 81);
            this.button6.TabIndex = 6;
            this.button6.Text = "            Paramètres";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.button7);
            this.panel8.Location = new System.Drawing.Point(4, 534);
            this.panel8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(270, 58);
            this.panel8.TabIndex = 13;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Image = global::Pointeuse.Properties.Resources.icons8_info_32;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(-25, -15);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button7.Name = "button7";
            this.button7.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button7.Size = new System.Drawing.Size(312, 81);
            this.button7.TabIndex = 6;
            this.button7.Text = "            Info";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 20;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // groupBox_pointages
            // 
            this.groupBox_pointages.Controls.Add(this.groupBox_soir);
            this.groupBox_pointages.Controls.Add(this.groupBox_midi);
            this.groupBox_pointages.Controls.Add(this.groupBox_apres_midi);
            this.groupBox_pointages.Controls.Add(this.groupBox_matin);
            this.groupBox_pointages.Location = new System.Drawing.Point(100, 23);
            this.groupBox_pointages.Name = "groupBox_pointages";
            this.groupBox_pointages.Size = new System.Drawing.Size(616, 335);
            this.groupBox_pointages.TabIndex = 13;
            this.groupBox_pointages.TabStop = false;
            this.groupBox_pointages.Text = "Pointages";
            // 
            // groupBox_soir
            // 
            this.groupBox_soir.Controls.Add(this.label_soir);
            this.groupBox_soir.Controls.Add(this.button_soir);
            this.groupBox_soir.Location = new System.Drawing.Point(380, 190);
            this.groupBox_soir.Name = "groupBox_soir";
            this.groupBox_soir.Size = new System.Drawing.Size(223, 129);
            this.groupBox_soir.TabIndex = 14;
            this.groupBox_soir.TabStop = false;
            // 
            // label_soir
            // 
            this.label_soir.AutoSize = true;
            this.label_soir.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_soir.ForeColor = System.Drawing.Color.Brown;
            this.label_soir.Location = new System.Drawing.Point(32, 21);
            this.label_soir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_soir.Name = "label_soir";
            this.label_soir.Size = new System.Drawing.Size(140, 25);
            this.label_soir.TabIndex = 11;
            this.label_soir.Text = "Fin de journée";
            // 
            // button_soir
            // 
            this.button_soir.BackColor = System.Drawing.Color.Brown;
            this.button_soir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_soir.FlatAppearance.BorderSize = 0;
            this.button_soir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_soir.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_soir.ForeColor = System.Drawing.Color.White;
            this.button_soir.Location = new System.Drawing.Point(51, 63);
            this.button_soir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_soir.Name = "button_soir";
            this.button_soir.Size = new System.Drawing.Size(132, 41);
            this.button_soir.TabIndex = 7;
            this.button_soir.Text = "Pointer";
            this.button_soir.UseVisualStyleBackColor = false;
            this.button_soir.Click += new System.EventHandler(this.button_soir_Click);
            // 
            // groupBox_midi
            // 
            this.groupBox_midi.Controls.Add(this.label_midi);
            this.groupBox_midi.Controls.Add(this.button_midi);
            this.groupBox_midi.Location = new System.Drawing.Point(380, 35);
            this.groupBox_midi.Name = "groupBox_midi";
            this.groupBox_midi.Size = new System.Drawing.Size(223, 129);
            this.groupBox_midi.TabIndex = 15;
            this.groupBox_midi.TabStop = false;
            // 
            // label_midi
            // 
            this.label_midi.AutoSize = true;
            this.label_midi.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_midi.ForeColor = System.Drawing.Color.Brown;
            this.label_midi.Location = new System.Drawing.Point(32, 21);
            this.label_midi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_midi.Name = "label_midi";
            this.label_midi.Size = new System.Drawing.Size(117, 25);
            this.label_midi.TabIndex = 11;
            this.label_midi.Text = "Pause repas";
            // 
            // button_midi
            // 
            this.button_midi.BackColor = System.Drawing.Color.Brown;
            this.button_midi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_midi.FlatAppearance.BorderSize = 0;
            this.button_midi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_midi.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_midi.ForeColor = System.Drawing.Color.White;
            this.button_midi.Location = new System.Drawing.Point(51, 63);
            this.button_midi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_midi.Name = "button_midi";
            this.button_midi.Size = new System.Drawing.Size(132, 41);
            this.button_midi.TabIndex = 7;
            this.button_midi.Text = "Pointer";
            this.button_midi.UseVisualStyleBackColor = false;
            this.button_midi.Click += new System.EventHandler(this.button_midi_Click);
            // 
            // groupBox_apres_midi
            // 
            this.groupBox_apres_midi.Controls.Add(this.label_apres_midi);
            this.groupBox_apres_midi.Controls.Add(this.button_apres_midi);
            this.groupBox_apres_midi.Location = new System.Drawing.Point(33, 190);
            this.groupBox_apres_midi.Name = "groupBox_apres_midi";
            this.groupBox_apres_midi.Size = new System.Drawing.Size(223, 129);
            this.groupBox_apres_midi.TabIndex = 16;
            this.groupBox_apres_midi.TabStop = false;
            // 
            // label_apres_midi
            // 
            this.label_apres_midi.AutoSize = true;
            this.label_apres_midi.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_apres_midi.ForeColor = System.Drawing.Color.Brown;
            this.label_apres_midi.Location = new System.Drawing.Point(32, 21);
            this.label_apres_midi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_apres_midi.Name = "label_apres_midi";
            this.label_apres_midi.Size = new System.Drawing.Size(185, 25);
            this.label_apres_midi.TabIndex = 11;
            this.label_apres_midi.Text = "Début d\'après-midi";
            // 
            // button_apres_midi
            // 
            this.button_apres_midi.BackColor = System.Drawing.Color.Brown;
            this.button_apres_midi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_apres_midi.FlatAppearance.BorderSize = 0;
            this.button_apres_midi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_apres_midi.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_apres_midi.ForeColor = System.Drawing.Color.White;
            this.button_apres_midi.Location = new System.Drawing.Point(51, 63);
            this.button_apres_midi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_apres_midi.Name = "button_apres_midi";
            this.button_apres_midi.Size = new System.Drawing.Size(132, 41);
            this.button_apres_midi.TabIndex = 7;
            this.button_apres_midi.Text = "Pointer";
            this.button_apres_midi.UseVisualStyleBackColor = false;
            this.button_apres_midi.Click += new System.EventHandler(this.button_apres_midi_Click);
            // 
            // groupBox_matin
            // 
            this.groupBox_matin.Controls.Add(this.label_matin);
            this.groupBox_matin.Controls.Add(this.button_matin);
            this.groupBox_matin.Location = new System.Drawing.Point(33, 35);
            this.groupBox_matin.Name = "groupBox_matin";
            this.groupBox_matin.Size = new System.Drawing.Size(223, 129);
            this.groupBox_matin.TabIndex = 13;
            this.groupBox_matin.TabStop = false;
            // 
            // label_matin
            // 
            this.label_matin.AutoSize = true;
            this.label_matin.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_matin.ForeColor = System.Drawing.Color.Brown;
            this.label_matin.Location = new System.Drawing.Point(32, 21);
            this.label_matin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_matin.Name = "label_matin";
            this.label_matin.Size = new System.Drawing.Size(160, 25);
            this.label_matin.TabIndex = 11;
            this.label_matin.Text = "Début de matiné";
            // 
            // button_matin
            // 
            this.button_matin.BackColor = System.Drawing.Color.Brown;
            this.button_matin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_matin.FlatAppearance.BorderSize = 0;
            this.button_matin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_matin.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_matin.ForeColor = System.Drawing.Color.White;
            this.button_matin.Location = new System.Drawing.Point(51, 63);
            this.button_matin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_matin.Name = "button_matin";
            this.button_matin.Size = new System.Drawing.Size(132, 41);
            this.button_matin.TabIndex = 7;
            this.button_matin.Text = "Pointer";
            this.button_matin.UseVisualStyleBackColor = false;
            this.button_matin.Click += new System.EventHandler(this.button_matin_Click);
            // 
            // progressBar_temp
            // 
            this.progressBar_temp.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.progressBar_temp.Location = new System.Drawing.Point(231, 555);
            this.progressBar_temp.Name = "progressBar_temp";
            this.progressBar_temp.Size = new System.Drawing.Size(503, 23);
            this.progressBar_temp.TabIndex = 14;
            this.progressBar_temp.Click += new System.EventHandler(this.progressBar_temp_Click);
            // 
            // timer_ProgressBar
            // 
            this.timer_ProgressBar.Tick += new System.EventHandler(this.timer_ProgressBar_Tick);
            // 
            // label_heure
            // 
            this.label_heure.AutoSize = true;
            this.label_heure.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_heure.ForeColor = System.Drawing.Color.Brown;
            this.label_heure.Location = new System.Drawing.Point(231, 527);
            this.label_heure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_heure.Name = "label_heure";
            this.label_heure.Size = new System.Drawing.Size(67, 25);
            this.label_heure.TabIndex = 12;
            this.label_heure.Text = "Heure";
            // 
            // Pointages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(930, 657);
            this.Controls.Add(this.label_heure);
            this.Controls.Add(this.progressBar_temp);
            this.Controls.Add(this.groupBox_pointages);
            this.Controls.Add(this.sidebar);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pointages";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pointages";
            this.Load += new System.EventHandler(this.Pointages_Load);
            this.sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.groupBox_pointages.ResumeLayout(false);
            this.groupBox_soir.ResumeLayout(false);
            this.groupBox_soir.PerformLayout();
            this.groupBox_midi.ResumeLayout(false);
            this.groupBox_midi.PerformLayout();
            this.groupBox_apres_midi.ResumeLayout(false);
            this.groupBox_apres_midi.PerformLayout();
            this.groupBox_matin.ResumeLayout(false);
            this.groupBox_matin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlowLayoutPanel sidebar;
        private Panel panel1;
        private Label label1;
        private PictureBox menuButton;
        private Panel panel2;
        private Button button8;
        private Button button1;
        private Panel panel3;
        private Button button2;
        private Panel panel4;
        private Button button3;
        private Panel panel5;
        private Button button4;
        private Panel panel6;
        private Button button5;
        private Panel panel7;
        private Button button6;
        private Panel panel8;
        private Button button7;
        private System.Windows.Forms.Timer sidebarTimer;
        private GroupBox groupBox_pointages;
        private GroupBox groupBox_soir;
        private Label label_soir;
        private Button button_soir;
        private GroupBox groupBox_midi;
        private Label label_midi;
        private Button button_midi;
        private GroupBox groupBox_apres_midi;
        private Label label_apres_midi;
        private Button button_apres_midi;
        private GroupBox groupBox_matin;
        private Label label_matin;
        private Button button_matin;
        private NewProgressBar progressBar_temp;
        private System.Windows.Forms.Timer timer_ProgressBar;
        private Label label_heure;
    }
}