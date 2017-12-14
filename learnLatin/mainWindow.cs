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

        }

        private void btn_sentences_Click(Object sender, EventArgs e)
        {

        }

        private void mainWindow_Load(Object sender, EventArgs e)
        {

        }
    }
}
