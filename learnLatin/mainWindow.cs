//-------------------------------------------------------------------------------------------------
//Author: Maederer
//Company: page one GmbH
//Created: December, 14th, 2017
//File: mainWindow.cs
//Short Description: the main window of my latin learn program
//-------------------------------------------------------------------------------------------------


using System;
using System.Windows.Forms;

namespace learnLatin
{
    public partial class mainWindow : Form
    {
        BackGroundSound bgSound;

        string learnLatinMainDirectory = ProgramFilesx86+ @"\learnLatin";



        public mainWindow()
        {
            InitializeComponent();
        }

        private void Btn_Nouns_Click(object sender, EventArgs e)
        {
            var frm_Nouns = new Nouns();
            frm_Nouns.Show();
        }

        private void Btn_Verbs_Click(object sender, EventArgs e)
        {
            var frm_Verbs = new Verbs();
            frm_Verbs.Show();
        }

        private void Btn_Adjectives_Click(object sender, EventArgs e)
        {

        }

        private void Btn_OtherWords_Click(object sender, EventArgs e)
        {
            var frm_Other_Words = new Vocabulary();
            frm_Other_Words.Show();
        }

        private void Btn_Sentences_Click(object sender, EventArgs e)
        {
            var frm_sentences = new Sentences();
            frm_sentences.Show();
        }

        private void MainWindow_Load(object sender, EventArgs e) => this.bgSound = new BackGroundSound(this.learnLatinMainDirectory + @"\Imperium.wav");

        static string ProgramFilesx86
        {
            get
            {
                if(8 == IntPtr.Size
                    || (!String.IsNullOrEmpty(Environment.GetEnvironmentVariable("PROCESSOR_ARCHITEW6432"))))
                {
                    return Environment.GetEnvironmentVariable("ProgramFiles(x86)");
                }

                return Environment.GetEnvironmentVariable("ProgramFiles");
            }
        }
    }
}
