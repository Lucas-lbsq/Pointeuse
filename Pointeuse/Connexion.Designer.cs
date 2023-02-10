namespace Pointeuse
{
    partial class Connexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connexion));
            this.label_creation = new System.Windows.Forms.Label();
            this.label_inscription = new System.Windows.Forms.Label();
            this.button_effacer = new System.Windows.Forms.Button();
            this.button_connecter = new System.Windows.Forms.Button();
            this.checkBox_effacer = new System.Windows.Forms.CheckBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.textBox_indentifiant = new System.Windows.Forms.TextBox();
            this.label_indentifiant = new System.Windows.Forms.Label();
            this.label_connexion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_creation
            // 
            this.label_creation.BackColor = System.Drawing.SystemColors.Control;
            this.label_creation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_creation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_creation.ForeColor = System.Drawing.Color.Brown;
            this.label_creation.Location = new System.Drawing.Point(39, 464);
            this.label_creation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_creation.Name = "label_creation";
            this.label_creation.Size = new System.Drawing.Size(257, 37);
            this.label_creation.TabIndex = 33;
            this.label_creation.Text = "Créer un compte";
            this.label_creation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_creation.Click += new System.EventHandler(this.label6_Click);
            // 
            // label_inscription
            // 
            this.label_inscription.BackColor = System.Drawing.SystemColors.Control;
            this.label_inscription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_inscription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label_inscription.Location = new System.Drawing.Point(45, 433);
            this.label_inscription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_inscription.Name = "label_inscription";
            this.label_inscription.Size = new System.Drawing.Size(251, 31);
            this.label_inscription.TabIndex = 32;
            this.label_inscription.Text = "Je n\'ai pas de compte";
            this.label_inscription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_effacer
            // 
            this.button_effacer.BackColor = System.Drawing.Color.White;
            this.button_effacer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_effacer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_effacer.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_effacer.ForeColor = System.Drawing.Color.Brown;
            this.button_effacer.Location = new System.Drawing.Point(44, 374);
            this.button_effacer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_effacer.Name = "button_effacer";
            this.button_effacer.Size = new System.Drawing.Size(252, 40);
            this.button_effacer.TabIndex = 31;
            this.button_effacer.Text = "Effacer";
            this.button_effacer.UseVisualStyleBackColor = false;
            this.button_effacer.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_connecter
            // 
            this.button_connecter.BackColor = System.Drawing.Color.Brown;
            this.button_connecter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_connecter.FlatAppearance.BorderSize = 0;
            this.button_connecter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_connecter.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_connecter.ForeColor = System.Drawing.Color.White;
            this.button_connecter.Location = new System.Drawing.Point(44, 314);
            this.button_connecter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_connecter.Name = "button_connecter";
            this.button_connecter.Size = new System.Drawing.Size(252, 40);
            this.button_connecter.TabIndex = 30;
            this.button_connecter.Text = "Se connecter";
            this.button_connecter.UseVisualStyleBackColor = false;
            this.button_connecter.Click += new System.EventHandler(this.button_connecter_Click);
            // 
            // checkBox_effacer
            // 
            this.checkBox_effacer.AutoSize = true;
            this.checkBox_effacer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox_effacer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox_effacer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.checkBox_effacer.Location = new System.Drawing.Point(207, 270);
            this.checkBox_effacer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBox_effacer.Name = "checkBox_effacer";
            this.checkBox_effacer.Size = new System.Drawing.Size(76, 21);
            this.checkBox_effacer.TabIndex = 29;
            this.checkBox_effacer.Text = "Afficher";
            this.checkBox_effacer.UseVisualStyleBackColor = true;
            this.checkBox_effacer.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBox_password
            // 
            this.textBox_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBox_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_password.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_password.ForeColor = System.Drawing.Color.Brown;
            this.textBox_password.Location = new System.Drawing.Point(44, 231);
            this.textBox_password.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_password.Multiline = true;
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '•';
            this.textBox_password.Size = new System.Drawing.Size(252, 32);
            this.textBox_password.TabIndex = 28;
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.BackColor = System.Drawing.SystemColors.Control;
            this.label_password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label_password.Location = new System.Drawing.Point(39, 203);
            this.label_password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(110, 21);
            this.label_password.TabIndex = 27;
            this.label_password.Text = "Mot de passe";
            // 
            // textBox_indentifiant
            // 
            this.textBox_indentifiant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBox_indentifiant.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_indentifiant.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_indentifiant.ForeColor = System.Drawing.Color.Brown;
            this.textBox_indentifiant.Location = new System.Drawing.Point(44, 156);
            this.textBox_indentifiant.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_indentifiant.Multiline = true;
            this.textBox_indentifiant.Name = "textBox_indentifiant";
            this.textBox_indentifiant.Size = new System.Drawing.Size(252, 32);
            this.textBox_indentifiant.TabIndex = 26;
            // 
            // label_indentifiant
            // 
            this.label_indentifiant.AutoSize = true;
            this.label_indentifiant.BackColor = System.Drawing.SystemColors.Control;
            this.label_indentifiant.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_indentifiant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label_indentifiant.Location = new System.Drawing.Point(39, 128);
            this.label_indentifiant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_indentifiant.Name = "label_indentifiant";
            this.label_indentifiant.Size = new System.Drawing.Size(91, 21);
            this.label_indentifiant.TabIndex = 25;
            this.label_indentifiant.Text = "Identifiant";
            // 
            // label_connexion
            // 
            this.label_connexion.AutoSize = true;
            this.label_connexion.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_connexion.ForeColor = System.Drawing.Color.Brown;
            this.label_connexion.Location = new System.Drawing.Point(36, 51);
            this.label_connexion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_connexion.Name = "label_connexion";
            this.label_connexion.Size = new System.Drawing.Size(181, 37);
            this.label_connexion.TabIndex = 24;
            this.label_connexion.Text = "Se connecter";
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 552);
            this.Controls.Add(this.label_creation);
            this.Controls.Add(this.label_inscription);
            this.Controls.Add(this.button_effacer);
            this.Controls.Add(this.button_connecter);
            this.Controls.Add(this.checkBox_effacer);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.textBox_indentifiant);
            this.Controls.Add(this.label_indentifiant);
            this.Controls.Add(this.label_connexion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Connexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_creation;
        private Label label_inscription;
        private Button button_effacer;
        private Button button_connecter;
        private CheckBox checkBox_effacer;
        private TextBox textBox_password;
        private Label label_password;
        private TextBox textBox_indentifiant;
        private Label label_indentifiant;
        private Label label_connexion;
    }
}