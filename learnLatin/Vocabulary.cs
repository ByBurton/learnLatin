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

        private void Other_Words_Load(object sender, EventArgs e)
        {
            this.FillOtherWordsListFromTextFile();

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

        private void Btn_Aufdecken_Click(object sender, EventArgs e) => this.txtBox_Deutsch.Text = this.ausgewaehltesWort.Deutsch;
        private void ClearTextBoxes() => this.txtBox_Deutsch.Text = String.Empty;
        private void Other_Words_FormClosing(object sender, FormClosingEventArgs e) => this.SaveOtherWordsListAsTextFile();

        private void FillOtherWordsListFromTextFile()
        {
            if(!Directory.Exists(@"C:\ProgramData\learnLatin"))
                Directory.CreateDirectory(@"C:\ProgramData\learnLatin");

            if(!File.Exists(@"C:\ProgramData\learnLatin\OtherWords.txt"))
                return;

            this.OtherWordsList.Clear();

            var stream = new FileStream(@"C:\ProgramData\learnLatin\OtherWords.txt", FileMode.Open, FileAccess.Read);
            var reader = new StreamReader(stream);

            var line = String.Empty;

            while((line = reader.ReadLine()) != null)
            {
                var word = new OtherWord(String.Empty, String.Empty);

                word.Lateinisch = line.Split(';')[0];
                word.Deutsch = line.Split(';')[1];

                this.OtherWordsList.Add(word);
            }


            reader.Close();
            stream.Close();
        }

        private void SaveOtherWordsListAsTextFile()
        {
            if(!Directory.Exists(@"C:\ProgramData\learnLatin"))
                Directory.CreateDirectory(@"C:\ProgramData\learnLatin");

            var stream = new FileStream(@"C:\ProgramData\learnLatin\OtherWords.txt", FileMode.OpenOrCreate, FileAccess.Write);
            var writer = new StreamWriter(stream);


            foreach(OtherWord word in this.OtherWordsList)
            {
                var line = String.Empty;

                line = word.Lateinisch + ";" + word.Deutsch;

                writer.WriteLine(line);
            }

            writer.Close();
            stream.Close();
        }

        private void Btn_NaechstesWort_Click(object sender, EventArgs e)
        {
            this.ausgewaehltesWort = CollectionExtension.RandomElement(this.OtherWordsList);

            this.txtBox_Lateinisch.Text = this.ausgewaehltesWort.Lateinisch;

            this.ClearTextBoxes();
        }

        private void Btn_WortHinzufuegen_Click(object sender, EventArgs e)
        {
            var word = new OtherWord(this.txtBox_Lateinisch.Text, this.txtBox_Deutsch.Text);
            this.OtherWordsList.Add(word);

            word = null;

            this.SaveOtherWordsListAsTextFile();

            MessageBox.Show("Das Wort wurde erfolgreich hinzugefügt!");

            this.btn_NaechstesWort.PerformClick();
        }
    }





    public class OtherWord
    {
        public string Lateinisch;
        public string Deutsch;

        public OtherWord(string Lateinisch, string Deutsch)
        {
            this.Lateinisch = Lateinisch;
            this.Deutsch = Deutsch;
        }
    }
}
