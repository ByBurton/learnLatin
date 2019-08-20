namespace learnLatin
{
    partial class Sentences
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sentences));
            this.btn_Aufdecken = new System.Windows.Forms.Button();
            this.btn_NaechsterSatz = new System.Windows.Forms.Button();
            this.btn_SatzHinzufuegen = new System.Windows.Forms.Button();
            this.txtBox_Deutsch = new System.Windows.Forms.TextBox();
            this.txtBox_Lateinisch = new System.Windows.Forms.TextBox();
            this.lbl_Deutsch = new System.Windows.Forms.Label();
            this.lbl_Lateinisch = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Aufdecken
            // 
            this.btn_Aufdecken.Location = new System.Drawing.Point(544, 216);
            this.btn_Aufdecken.Name = "btn_Aufdecken";
            this.btn_Aufdecken.Size = new System.Drawing.Size(112, 23);
            this.btn_Aufdecken.TabIndex = 9;
            this.btn_Aufdecken.Text = "Aufdecken";
            this.btn_Aufdecken.UseVisualStyleBackColor = true;
            this.btn_Aufdecken.Click += new System.EventHandler(this.Btn_Aufdecken_Click);
            // 
            // btn_NaechsterSatz
            // 
            this.btn_NaechsterSatz.Location = new System.Drawing.Point(544, 256);
            this.btn_NaechsterSatz.Name = "btn_NaechsterSatz";
            this.btn_NaechsterSatz.Size = new System.Drawing.Size(112, 23);
            this.btn_NaechsterSatz.TabIndex = 8;
            this.btn_NaechsterSatz.Text = "Nächster Satz";
            this.btn_NaechsterSatz.UseVisualStyleBackColor = true;
            this.btn_NaechsterSatz.Click += new System.EventHandler(this.Btn_NaechsterSatz_Click);
            // 
            // btn_SatzHinzufuegen
            // 
            this.btn_SatzHinzufuegen.Location = new System.Drawing.Point(536, 296);
            this.btn_SatzHinzufuegen.Name = "btn_SatzHinzufuegen";
            this.btn_SatzHinzufuegen.Size = new System.Drawing.Size(120, 23);
            this.btn_SatzHinzufuegen.TabIndex = 7;
            this.btn_SatzHinzufuegen.Text = "Satz hinzufügen";
            this.btn_SatzHinzufuegen.UseVisualStyleBackColor = true;
            this.btn_SatzHinzufuegen.Click += new System.EventHandler(this.Btn_SatzHinzufuegen_Click);
            // 
            // txtBox_Deutsch
            // 
            this.txtBox_Deutsch.Location = new System.Drawing.Point(24, 120);
            this.txtBox_Deutsch.Name = "txtBox_Deutsch";
            this.txtBox_Deutsch.Size = new System.Drawing.Size(632, 20);
            this.txtBox_Deutsch.TabIndex = 13;
            // 
            // txtBox_Lateinisch
            // 
            this.txtBox_Lateinisch.Location = new System.Drawing.Point(24, 48);
            this.txtBox_Lateinisch.Name = "txtBox_Lateinisch";
            this.txtBox_Lateinisch.Size = new System.Drawing.Size(632, 20);
            this.txtBox_Lateinisch.TabIndex = 12;
            // 
            // lbl_Deutsch
            // 
            this.lbl_Deutsch.AutoSize = true;
            this.lbl_Deutsch.Location = new System.Drawing.Point(24, 96);
            this.lbl_Deutsch.Name = "lbl_Deutsch";
            this.lbl_Deutsch.Size = new System.Drawing.Size(47, 13);
            this.lbl_Deutsch.TabIndex = 11;
            this.lbl_Deutsch.Text = "Deutsch";
            // 
            // lbl_Lateinisch
            // 
            this.lbl_Lateinisch.AutoSize = true;
            this.lbl_Lateinisch.Location = new System.Drawing.Point(24, 24);
            this.lbl_Lateinisch.Name = "lbl_Lateinisch";
            this.lbl_Lateinisch.Size = new System.Drawing.Size(55, 13);
            this.lbl_Lateinisch.TabIndex = 10;
            this.lbl_Lateinisch.Text = "Lateinisch";
            // 
            // Sentences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::learnLatin.Properties.Resources.roman_city;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(682, 407);
            this.Controls.Add(this.txtBox_Deutsch);
            this.Controls.Add(this.txtBox_Lateinisch);
            this.Controls.Add(this.lbl_Deutsch);
            this.Controls.Add(this.lbl_Lateinisch);
            this.Controls.Add(this.btn_Aufdecken);
            this.Controls.Add(this.btn_NaechsterSatz);
            this.Controls.Add(this.btn_SatzHinzufuegen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sentences";
            this.Text = "Sentences";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Sentences_FormClosing);
            this.Load += new System.EventHandler(this.Sentences_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Aufdecken;
        private System.Windows.Forms.Button btn_NaechsterSatz;
        private System.Windows.Forms.Button btn_SatzHinzufuegen;
        private System.Windows.Forms.TextBox txtBox_Deutsch;
        private System.Windows.Forms.TextBox txtBox_Lateinisch;
        private System.Windows.Forms.Label lbl_Deutsch;
        private System.Windows.Forms.Label lbl_Lateinisch;
    }
}