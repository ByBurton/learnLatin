namespace learnLatin
{
    partial class Vocabulary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vocabulary));
            this.lbl_Lateinisch = new System.Windows.Forms.Label();
            this.lbl_Deutsch = new System.Windows.Forms.Label();
            this.txtBox_Lateinisch = new System.Windows.Forms.TextBox();
            this.txtBox_Deutsch = new System.Windows.Forms.TextBox();
            this.btn_WortHinzufuegen = new System.Windows.Forms.Button();
            this.btn_NaechstesWort = new System.Windows.Forms.Button();
            this.btn_Aufdecken = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Lateinisch
            // 
            this.lbl_Lateinisch.AutoSize = true;
            this.lbl_Lateinisch.Location = new System.Drawing.Point(160, 48);
            this.lbl_Lateinisch.Name = "lbl_Lateinisch";
            this.lbl_Lateinisch.Size = new System.Drawing.Size(55, 13);
            this.lbl_Lateinisch.TabIndex = 0;
            this.lbl_Lateinisch.Text = "Lateinisch";
            // 
            // lbl_Deutsch
            // 
            this.lbl_Deutsch.AutoSize = true;
            this.lbl_Deutsch.Location = new System.Drawing.Point(352, 48);
            this.lbl_Deutsch.Name = "lbl_Deutsch";
            this.lbl_Deutsch.Size = new System.Drawing.Size(47, 13);
            this.lbl_Deutsch.TabIndex = 1;
            this.lbl_Deutsch.Text = "Deutsch";
            // 
            // txtBox_Lateinisch
            // 
            this.txtBox_Lateinisch.Location = new System.Drawing.Point(144, 64);
            this.txtBox_Lateinisch.Name = "txtBox_Lateinisch";
            this.txtBox_Lateinisch.Size = new System.Drawing.Size(100, 20);
            this.txtBox_Lateinisch.TabIndex = 2;
            // 
            // txtBox_Deutsch
            // 
            this.txtBox_Deutsch.Location = new System.Drawing.Point(328, 64);
            this.txtBox_Deutsch.Name = "txtBox_Deutsch";
            this.txtBox_Deutsch.Size = new System.Drawing.Size(100, 20);
            this.txtBox_Deutsch.TabIndex = 3;
            // 
            // btn_WortHinzufuegen
            // 
            this.btn_WortHinzufuegen.Location = new System.Drawing.Point(464, 336);
            this.btn_WortHinzufuegen.Name = "btn_WortHinzufuegen";
            this.btn_WortHinzufuegen.Size = new System.Drawing.Size(120, 23);
            this.btn_WortHinzufuegen.TabIndex = 4;
            this.btn_WortHinzufuegen.Text = "Wort hinzufügen";
            this.btn_WortHinzufuegen.UseVisualStyleBackColor = true;
            this.btn_WortHinzufuegen.Click += new System.EventHandler(this.Btn_WortHinzufuegen_Click);
            // 
            // btn_NaechstesWort
            // 
            this.btn_NaechstesWort.Location = new System.Drawing.Point(232, 144);
            this.btn_NaechstesWort.Name = "btn_NaechstesWort";
            this.btn_NaechstesWort.Size = new System.Drawing.Size(112, 23);
            this.btn_NaechstesWort.TabIndex = 5;
            this.btn_NaechstesWort.Text = "Nächstes Wort";
            this.btn_NaechstesWort.UseVisualStyleBackColor = true;
            this.btn_NaechstesWort.Click += new System.EventHandler(this.Btn_NaechstesWort_Click);
            // 
            // btn_Aufdecken
            // 
            this.btn_Aufdecken.Location = new System.Drawing.Point(232, 112);
            this.btn_Aufdecken.Name = "btn_Aufdecken";
            this.btn_Aufdecken.Size = new System.Drawing.Size(112, 23);
            this.btn_Aufdecken.TabIndex = 6;
            this.btn_Aufdecken.Text = "Aufdecken";
            this.btn_Aufdecken.UseVisualStyleBackColor = true;
            this.btn_Aufdecken.Click += new System.EventHandler(this.Btn_Aufdecken_Click);
            // 
            // Vocabulary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::learnLatin.Properties.Resources.roman_city;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(612, 386);
            this.Controls.Add(this.btn_Aufdecken);
            this.Controls.Add(this.btn_NaechstesWort);
            this.Controls.Add(this.btn_WortHinzufuegen);
            this.Controls.Add(this.txtBox_Deutsch);
            this.Controls.Add(this.txtBox_Lateinisch);
            this.Controls.Add(this.lbl_Deutsch);
            this.Controls.Add(this.lbl_Lateinisch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Vocabulary";
            this.Text = "Vokabeltrainer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Other_Words_FormClosing);
            this.Load += new System.EventHandler(this.Other_Words_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Lateinisch;
        private System.Windows.Forms.Label lbl_Deutsch;
        private System.Windows.Forms.TextBox txtBox_Lateinisch;
        private System.Windows.Forms.TextBox txtBox_Deutsch;
        private System.Windows.Forms.Button btn_WortHinzufuegen;
        private System.Windows.Forms.Button btn_NaechstesWort;
        private System.Windows.Forms.Button btn_Aufdecken;
    }
}