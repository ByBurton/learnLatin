//-------------------------------------------------------------------------------------------------
//Author: Maederer
//Company: page one GmbH
//Created: December, 19th, 2017
//File: Other_Words.cs
//Short Description: learn the different words (Vocabulary)
//-------------------------------------------------------------------------------------------------


using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace learnLatin
{
    public partial class Vocabulary : Form
    {
        public List<OtherWord> OtherWordsList = new List<OtherWord>();
        private OtherWord ausgewaehltesWort;

        public Vocabulary()
        {
            InitializeComponent();
        }

        private void Other_Words_Load(Object sender, EventArgs e)
        {
            this.fillOtherWordsListFromTextFile();

            if(this.OtherWordsList.Count == 0)
                this.FillOtherWordsListWithDefaults();

            this.btn_NaechstesWort.PerformClick();
        }

        public void FillOtherWordsListWithDefaults()
        {
            this.OtherWordsList.Add(new OtherWord("circus", "Zirkus, Rennbahn"));
            this.OtherWordsList.Add(new OtherWord("gaudere", "sich freuen"));
            this.OtherWordsList.Add(new OtherWord("clamare", "laut rufen, schreien"));
            this.OtherWordsList.Add(new OtherWord("et", "und"));
            this.OtherWordsList.Add(new OtherWord("ave!", "sei gegrüßt!"));
            this.OtherWordsList.Add(new OtherWord("adesse", "da sein"));
            this.OtherWordsList.Add(new OtherWord("rogare", "bitten, erbitten, fragen"));
            this.OtherWordsList.Add(new OtherWord("ubi?", "wo?"));
        }

        private void btn_Aufdecken_Click(Object sender, EventArgs e)
        {
            this.txtBox_Deutsch.Text = this.ausgewaehltesWort.Deutsch;
        }

        private void fillOtherWordsListFromTextFile()
        {
            if(!Directory.Exists(@"C:\ProgramData\learnLatin"))
                Directory.CreateDirectory(@"C:\ProgramData\learnLatin");

            if(!File.Exists(@"C:\ProgramData\learnLatin\OtherWords.txt"))
                return;

            this.OtherWordsList.Clear();

            FileStream stream = new FileStream(@"C:\ProgramData\learnLatin\OtherWords.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            String line = String.Empty;

            while((line = reader.ReadLine()) != null)
            {
                OtherWord word = new OtherWord(String.Empty, String.Empty);

                word.Lateinisch = line.Split(';')[0];
                word.Deutsch = line.Split(';')[1];

                this.OtherWordsList.Add(word);
            }


            reader.Close();
            stream.Close();
        }

        private void saveOtherWordsListAsTextFile()
        {
            if(!Directory.Exists(@"C:\ProgramData\learnLatin"))
                Directory.CreateDirectory(@"C:\ProgramData\learnLatin");

            FileStream stream = new FileStream(@"C:\ProgramData\learnLatin\OtherWords.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);


            foreach(OtherWord word in this.OtherWordsList)
            {
                String line = String.Empty;

                line = word.Lateinisch + ";" + word.Deutsch;

                writer.WriteLine(line);
            }

            writer.Close();
            stream.Close();
        }

        private void btn_NaechstesWort_Click(Object sender, EventArgs e)
        {
            this.ausgewaehltesWort = CollectionExtension.RandomElement(this.OtherWordsList);

            this.txtBox_Lateinisch.Text = this.ausgewaehltesWort.Lateinisch;

            this.clearTextBoxes();
        }

        private void btn_WortHinzufuegen_Click(Object sender, EventArgs e)
        {
            OtherWord word = new OtherWord(this.txtBox_Lateinisch.Text, this.txtBox_Deutsch.Text);
            this.OtherWordsList.Add(word);

            word = null;

            this.saveOtherWordsListAsTextFile();

            MessageBox.Show("Das Wort wurde erfolgreich hinzugefügt!");

            this.btn_NaechstesWort.PerformClick();
        }

        private void clearTextBoxes()
        {
            this.txtBox_Deutsch.Text = String.Empty;
        }

        private void Other_Words_FormClosing(Object sender, FormClosingEventArgs e)
        {
            this.saveOtherWordsListAsTextFile();
        }
    }





    public class OtherWord
    {
        public String Lateinisch;
        public String Deutsch;

        public OtherWord(String Lateinisch, String Deutsch)
        {
            this.Lateinisch = Lateinisch;
            this.Deutsch = Deutsch;
        }
    }
}
