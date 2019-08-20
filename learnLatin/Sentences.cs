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

        private void Btn_Aufdecken_Click(object sender, EventArgs e) => this.txtBox_Deutsch.Text = this.ausgewaehlterSatz.Deutsch;
        private void ClearTextBoxes() => this.txtBox_Deutsch.Text = String.Empty;
        private void Sentences_FormClosing(object sender, FormClosingEventArgs e) => this.SaveSentencesListToTextFile();

        private void Btn_NaechsterSatz_Click(object sender, EventArgs e)
        {
            this.ausgewaehlterSatz = CollectionExtension.RandomElement(this.SentenceList);

            this.txtBox_Lateinisch.Text = this.ausgewaehlterSatz.Lateinisch;

            this.ClearTextBoxes();
        }

        private void Btn_SatzHinzufuegen_Click(object sender, EventArgs e)
        {
            var sentence = new Sentence(this.txtBox_Lateinisch.Text, this.txtBox_Deutsch.Text);
            this.SentenceList.Add(sentence);

            sentence = null;

            this.SaveSentencesListToTextFile();

            MessageBox.Show("Der Satz wurde erfolgreich hinzugefügt!");

            this.btn_NaechsterSatz.PerformClick();
        }

        private void Sentences_Load(object sender, EventArgs e)
        {
            this.FillSentencesListFromTextFile();

            if(this.SentenceList.Count == 0)
                this.FillSentencesListWithDefaults();

            this.btn_NaechsterSatz.PerformClick();
        }

        private void FillSentencesListFromTextFile()
        {
            if(!Directory.Exists(@"C:\ProgramData\learnLatin"))
                Directory.CreateDirectory(@"C:\ProgramData\learnLatin");

            if(!File.Exists(@"C:\ProgramData\learnLatin\Sentences.txt"))
                return;

            this.SentenceList.Clear();

            var stream = new FileStream(@"C:\ProgramData\learnLatin\Sentences.txt", FileMode.Open, FileAccess.Read);
            var reader = new StreamReader(stream);

            var line = String.Empty;

            while((line = reader.ReadLine()) != null)
            {
                var sentence = new Sentence(String.Empty, String.Empty);

                sentence.Lateinisch = line.Split(';')[0];
                sentence.Deutsch = line.Split(';')[1];

                this.SentenceList.Add(sentence);
            }


            reader.Close();
            stream.Close();
        }

        private void SaveSentencesListToTextFile()
        {
            if(!Directory.Exists(@"C:\ProgramData\learnLatin"))
                Directory.CreateDirectory(@"C:\ProgramData\learnLatin");

            var stream = new FileStream(@"C:\ProgramData\learnLatin\Sentences.txt", FileMode.OpenOrCreate, FileAccess.Write);
            var writer = new StreamWriter(stream);


            foreach(Sentence sentence in this.SentenceList)
            {
                var line = String.Empty;

                line = sentence.Lateinisch + ";" + sentence.Deutsch;

                writer.WriteLine(line);
            }

            writer.Close();
            stream.Close();

        }
        
        private void FillSentencesListWithDefaults()
        {
            this.SentenceList.Add(new Sentence("Senator in forum properat, nam ibi curia est.", "Der Senator eilt auf den Marktplatz, denn dort ist die Kurie."));
            this.SentenceList.Add(new Sentence("Hic turba stat et clamat: \"Ave, senator!\"", "Hier steht eine Menschenmenge und ruft: \"Sei gegrüßt, Senator!\""));
            this.SentenceList.Add(new Sentence("Senator gaudet et clamat: \"Salvete!\"", "Der Senator freut sich und ruft: \"Seid gegrüßt!\""));
            this.SentenceList.Add(new Sentence("Subito servus adest et rogat: \"Ubi Marcus Aquilius Florus" +
                "senator est ?\" Turba: \"Ibi est!\"", "Plötzlich kommt ein Sklave hinzu und fragt: \"Wo ist der Senator Marcus Aquilius Florus?\" Menschenmenge: \"Dort ist er!\""));
            this.SentenceList.Add(new Sentence("Senator ridet, tum in curiam properat.", "Der Senatorlacht, dann eilt er in die Kurie."));
        }
    }










    public class Sentence
    {
        public string Lateinisch;
        public string Deutsch;

        public Sentence(string Lateinisch, string Deutsch)
        {
            this.Lateinisch = Lateinisch;
            this.Deutsch = Deutsch;
        }
    }
}
