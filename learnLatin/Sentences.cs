using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace learnLatin
{
    public partial class Sentences : Form
    {
        public List<Sentence> SentenceList = new List<Sentence>();
        private Sentence ausgewaehlterSatz;

        public Sentences()
        {
            InitializeComponent();
        }

        private void btn_Aufdecken_Click(Object sender, EventArgs e)
        {
            this.txtBox_Deutsch.Text = this.ausgewaehlterSatz.Deutsch;
        }

        private void btn_NaechsterSatz_Click(Object sender, EventArgs e)
        {
            this.ausgewaehlterSatz = CollectionExtension.RandomElement(this.SentenceList);

            this.txtBox_Lateinisch.Text = this.ausgewaehlterSatz.Lateinisch;

            this.clearTextBoxes();
        }

        private void btn_SatzHinzufuegen_Click(Object sender, EventArgs e)
        {
            Sentence sentence = new Sentence(this.txtBox_Lateinisch.Text, this.txtBox_Deutsch.Text);
            this.SentenceList.Add(sentence);

            sentence = null;

            this.saveSentencesListToTextFile();

            MessageBox.Show("Der Satz wurde erfolgreich hinzugefügt!");

            this.btn_NaechsterSatz.PerformClick();
        }

        private void clearTextBoxes()
        {
            this.txtBox_Deutsch.Text = String.Empty;
        }

        private void Sentences_FormClosing(Object sender, FormClosingEventArgs e)
        {
            this.saveSentencesListToTextFile();
        }

        private void Sentences_Load(Object sender, EventArgs e)
        {
            this.fillSentencesListFromTextFile();

            if(this.SentenceList.Count == 0)
                this.fillSentencesListWithDefaults();

            this.btn_NaechsterSatz.PerformClick();
        }

        private void fillSentencesListFromTextFile()
        {
            if(!Directory.Exists(@"C:\ProgramData\learnLatin"))
                Directory.CreateDirectory(@"C:\ProgramData\learnLatin");

            if(!File.Exists(@"C:\ProgramData\learnLatin\Sentences.txt"))
                return;

            this.SentenceList.Clear();

            FileStream stream = new FileStream(@"C:\ProgramData\learnLatin\OtherWords.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            String line = String.Empty;

            while((line = reader.ReadLine()) != null)
            {
                Sentence sentence = new Sentence(String.Empty, String.Empty);

                sentence.Lateinisch = line.Split(';')[0];
                sentence.Deutsch = line.Split(';')[1];

                this.SentenceList.Add(sentence);
            }


            reader.Close();
            stream.Close();
        }

        private void saveSentencesListToTextFile()
        {
            if(!Directory.Exists(@"C:\ProgramData\learnLatin"))
                Directory.CreateDirectory(@"C:\ProgramData\learnLatin");

            FileStream stream = new FileStream(@"C:\ProgramData\learnLatin\Sentences.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);


            foreach(Sentence sentence in this.SentenceList)
            {
                String line = String.Empty;

                line = sentence.Lateinisch + ";" + sentence.Deutsch;

                writer.WriteLine(line);
            }

            writer.Close();
            stream.Close();

        }
        
        private void fillSentencesListWithDefaults()
        {
            this.SentenceList.Add(new Sentence("Senator in forum properat, nam ibi curia est.", "Der Senator eilt auf den Marktplatz, denn dort ist die Kurie."));
        }
    }










    public class Sentence
    {
        public String Lateinisch;
        public String Deutsch;

        public Sentence(String Lateinisch, String Deutsch)
        {
            this.Lateinisch = Lateinisch;
            this.Deutsch = Deutsch;
        }
    }
}
