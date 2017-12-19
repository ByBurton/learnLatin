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

        String learnLatinMainDirectory = programFilesx86() + @"\learnLatin";



        public mainWindow()
        {
            InitializeComponent();
        }

        private void btn_Nouns_Click(Object sender, EventArgs e)
        {
            Nouns frm_Nouns = new Nouns();
            frm_Nouns.Show();
        }

        private void btn_Verbs_Click(Object sender, EventArgs e)
        {
            Verbs frm_Verbs = new Verbs();
            frm_Verbs.Show();
        }

        private void btn_Adjectives_Click(Object sender, EventArgs e)
        {

        }

        private void btn_OtherWords_Click(Object sender, EventArgs e)
        {
            Vocabulary frm_Other_Words = new Vocabulary();
            frm_Other_Words.Show();
        }

        private void btn_Sentences_Click(Object sender, EventArgs e)
        {
            Sentences frm_sentences = new Sentences();
            frm_sentences.Show();
        }

        private void mainWindow_Load(Object sender, EventArgs e)
        {
            this.bgSound = new BackGroundSound(this.learnLatinMainDirectory + @"\Imperium.wav");
        }

        static String programFilesx86()
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
