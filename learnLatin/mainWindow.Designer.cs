namespace learnLatin
{
    partial class mainWindow
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
            if(disposing && (components != null))
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
            this.btn_Nomen = new System.Windows.Forms.Button();
            this.btn_Verben = new System.Windows.Forms.Button();
            this.btn_Adjektive = new System.Windows.Forms.Button();
            this.btn_AndereWoerter = new System.Windows.Forms.Button();
            this.btn_Saetze = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Nomen
            // 
            this.btn_Nomen.Location = new System.Drawing.Point(96, 64);
            this.btn_Nomen.Name = "btn_Nomen";
            this.btn_Nomen.Size = new System.Drawing.Size(75, 23);
            this.btn_Nomen.TabIndex = 0;
            this.btn_Nomen.Text = "Nomen";
            this.btn_Nomen.UseVisualStyleBackColor = true;
            this.btn_Nomen.Click += new System.EventHandler(this.btn_Nouns_Click);
            // 
            // btn_Verben
            // 
            this.btn_Verben.Location = new System.Drawing.Point(192, 64);
            this.btn_Verben.Name = "btn_Verben";
            this.btn_Verben.Size = new System.Drawing.Size(75, 23);
            this.btn_Verben.TabIndex = 1;
            this.btn_Verben.Text = "Verben";
            this.btn_Verben.UseVisualStyleBackColor = true;
            this.btn_Verben.Click += new System.EventHandler(this.btn_Verbs_Click);
            // 
            // btn_Adjektive
            // 
            this.btn_Adjektive.Location = new System.Drawing.Point(288, 64);
            this.btn_Adjektive.Name = "btn_Adjektive";
            this.btn_Adjektive.Size = new System.Drawing.Size(75, 23);
            this.btn_Adjektive.TabIndex = 2;
            this.btn_Adjektive.Text = "Adjektive";
            this.btn_Adjektive.UseVisualStyleBackColor = true;
            this.btn_Adjektive.Click += new System.EventHandler(this.btn_Adjectives_Click);
            // 
            // btn_AndereWoerter
            // 
            this.btn_AndereWoerter.Location = new System.Drawing.Point(376, 64);
            this.btn_AndereWoerter.Name = "btn_AndereWoerter";
            this.btn_AndereWoerter.Size = new System.Drawing.Size(80, 23);
            this.btn_AndereWoerter.TabIndex = 3;
            this.btn_AndereWoerter.Text = "Andere Wörter";
            this.btn_AndereWoerter.UseVisualStyleBackColor = true;
            this.btn_AndereWoerter.Click += new System.EventHandler(this.btn_OtherWords_Click);
            // 
            // btn_Saetze
            // 
            this.btn_Saetze.Location = new System.Drawing.Point(608, 368);
            this.btn_Saetze.Name = "btn_Saetze";
            this.btn_Saetze.Size = new System.Drawing.Size(75, 23);
            this.btn_Saetze.TabIndex = 4;
            this.btn_Saetze.Text = "Sätze";
            this.btn_Saetze.UseVisualStyleBackColor = true;
            this.btn_Saetze.Click += new System.EventHandler(this.btn_sentences_Click);
            // 
            // mainWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(796, 473);
            this.Controls.Add(this.btn_Saetze);
            this.Controls.Add(this.btn_AndereWoerter);
            this.Controls.Add(this.btn_Adjektive);
            this.Controls.Add(this.btn_Verben);
            this.Controls.Add(this.btn_Nomen);
            this.Name = "mainWindow";
            this.Text = "mainWindow";
            this.Load += new System.EventHandler(this.mainWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Nomen;
        private System.Windows.Forms.Button btn_Verben;
        private System.Windows.Forms.Button btn_Adjektive;
        private System.Windows.Forms.Button btn_AndereWoerter;
        private System.Windows.Forms.Button btn_Saetze;
    }
}

