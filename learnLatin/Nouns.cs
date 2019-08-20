//-------------------------------------------------------------------------------------------------
//Author: Maederer
//Company: page one GmbH
//Created: December, 14th, 2017
//File: Nouns.cs
//Short Description: a class, that features showing random latin nouns
//-------------------------------------------------------------------------------------------------


using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace learnLatin
{
    public partial class Nouns : Form
    {
        public List<Nomen> NomensListe = new List<Nomen>();
        private Nomen ausgewaehltesNomen;

        public Nouns()
        {
            InitializeComponent();
        }

        private void Nouns_Load(object sender, EventArgs e)
        {
            this.FillNomensListeFromTextFile();

            if(this.NomensListe.Count == 0)
                FillNomenListWithDefaults();

            this.btn_NaechstesNomen.PerformClick();
        }

        public void FillNomenListWithDefaults()
        {
            this.NomensListe.Add(new Nomen("servus", "servi", "servo", "servum", "servo", "servi", "servorum", "servis", "servos", "servis", "Sklave"));
            this.NomensListe.Add(new Nomen("amica", "amicae", "amicae", "amicam", "amica", "amicae", "amicarum", "amicis", "amicas", "amicis", "Freundin"));
            this.NomensListe.Add(new Nomen("mercator", "mercatoris", "mercatori", "mercatorem", "mercatore", "mercatores", "mercatorum", "mercatoribus", "mercatores", "mercatoribus", "Kaufmann"));
            this.NomensListe.Add(new Nomen("forum", "fori", "foro", "forum", "foro", "fora", "fororum", "foris", "fora", "foris", "Marktplatz, Forum, Öffentlichkeit"));
        }

        private void Btn_NaechstesNomen_Click(object sender, EventArgs e)
        {
            this.ausgewaehltesNomen = CollectionExtension.RandomElement(this.NomensListe);

            this.txtBox_NominativSingular.Text = this.ausgewaehltesNomen.NominativSingular;

            this.ClearTextBoxes();
        }

        private void ClearTextBoxes()
        {
            this.txtBox_ZuDeutsch.Text = String.Empty;

            this.txtBox_GenitivSingular.Text = String.Empty;
            this.txtBox_DativSingular.Text = String.Empty;
            this.txtBox_AkkusativSingular.Text = String.Empty;
            this.txtBox_AblativSingular.Text = String.Empty;

            this.txtBox_NominativPlural.Text = String.Empty;
            this.txtBox_GenitivPlural.Text = String.Empty;
            this.txtBox_DativPlural.Text = String.Empty;
            this.txtBox_AkkusativPlural.Text = String.Empty;
            this.txtBox_AblativPlural.Text = String.Empty;
        }

        private void Btn_LueckenFuellen_Click(object sender, EventArgs e)
        {
            this.txtBox_ZuDeutsch.Text = this.ausgewaehltesNomen.ZuDeutsch;

            this.txtBox_GenitivSingular.Text = this.ausgewaehltesNomen.GenitivSingular;
            this.txtBox_DativSingular.Text = this.ausgewaehltesNomen.DativSingular;
            this.txtBox_AkkusativSingular.Text = this.ausgewaehltesNomen.AkkusativSingular;
            this.txtBox_AblativSingular.Text = this.ausgewaehltesNomen.AblativSingular;

            this.txtBox_NominativPlural.Text = this.ausgewaehltesNomen.NominativPlural;
            this.txtBox_GenitivPlural.Text = this.ausgewaehltesNomen.GenitivPlural;
            this.txtBox_DativPlural.Text = this.ausgewaehltesNomen.DativPlural;
            this.txtBox_AkkusativPlural.Text = this.ausgewaehltesNomen.AkkusativPlural;
            this.txtBox_AblativPlural.Text = this.ausgewaehltesNomen.AblativPlural;
        }



        private void SaveNomensListeAsTextFile()
        {
            if(!Directory.Exists(@"C:\ProgramData\learnLatin"))
                Directory.CreateDirectory(@"C:\ProgramData\learnLatin");

            var stream = new FileStream(@"C:\ProgramData\learnLatin\Nomen.txt", FileMode.OpenOrCreate, FileAccess.Write);
            var writer = new StreamWriter(stream);


            foreach(Nomen nomen in this.NomensListe)
            {
                var line = String.Empty;

                var singular = nomen.NominativSingular + ";" + nomen.GenitivSingular + ";" + nomen.DativSingular + ";" + nomen.AkkusativSingular + ";" +
                    nomen.AblativSingular + ";" + nomen.VokativSingular + ";" + nomen.LokativSingular + "#";
                var plural = nomen.NominativPlural + ";" + nomen.GenitivPlural + ";" + nomen.DativPlural + ";" + nomen.AkkusativPlural + ";" + nomen.AblativPlural + ";" + nomen.VokativPlural + ";" + nomen.LokativPlural;

                line = singular + plural + "#" + nomen.ZuDeutsch;

                writer.WriteLine(line);
            }

            writer.Close();
            stream.Close();
        }

        private void FillNomensListeFromTextFile()
        {
            if(!Directory.Exists(@"C:\ProgramData\learnLatin"))
                Directory.CreateDirectory(@"C:\ProgramData\learnLatin");

            if(!File.Exists(@"C:\ProgramData\learnLatin\Nomen.txt"))
                return;

            this.NomensListe.Clear();

            var stream = new FileStream(@"C:\ProgramData\learnLatin\Nomen.txt", FileMode.Open, FileAccess.Read);
            var reader = new StreamReader(stream);

            var line = String.Empty;

            while((line = reader.ReadLine()) != null)
            {
                var nomen = new Nomen(String.Empty, String.Empty, String.Empty, String.Empty, String.Empty, String.Empty, String.Empty, String.Empty,
                    String.Empty, String.Empty, String.Empty);

                var singular = line.Split('#')[0].Split(';');
                var plural = line.Split('#')[1].Split(';');
                var zuDeutsch = line.Split('#')[2];

                nomen.NominativSingular = singular[0];
                nomen.GenitivSingular = singular[1];
                nomen.DativSingular = singular[2];
                nomen.AkkusativSingular = singular[3];
                nomen.AblativSingular = singular[4];
                nomen.VokativSingular = singular[5];
                nomen.LokativSingular = singular[6];

                nomen.NominativPlural = plural[0];
                nomen.GenitivPlural = plural[1];
                nomen.DativPlural = plural[2];
                nomen.AkkusativPlural = plural[3];
                nomen.AblativPlural = plural[4];
                nomen.VokativPlural = plural[5];
                nomen.LokativPlural = plural[6];

                nomen.ZuDeutsch = zuDeutsch;

                this.NomensListe.Add(nomen);
            }


            reader.Close();
            stream.Close();
        }

        private void Nouns_FormClosing(object sender, FormClosingEventArgs e) => this.SaveNomensListeAsTextFile();

        private void Btn_NomenHinzufuegen_Click(object sender, EventArgs e)
        {
            var nomen = new Nomen(this.txtBox_NominativSingular.Text, this.txtBox_GenitivSingular.Text, this.txtBox_DativSingular.Text, this.txtBox_AkkusativSingular.Text,
                this.txtBox_AblativSingular.Text, this.txtBox_NominativPlural.Text, this.txtBox_GenitivPlural.Text, this.txtBox_DativPlural.Text, this.txtBox_AkkusativPlural.Text,
                this.txtBox_AblativPlural.Text, this.txtBox_ZuDeutsch.Text);

            nomen.AddLokativ(String.Empty, String.Empty);
            nomen.AddVokativ(String.Empty, String.Empty);

            this.NomensListe.Add(nomen);
            nomen = null;

            this.SaveNomensListeAsTextFile();

            MessageBox.Show("Das Nomen wurde erfolgreich hinzugefügt!");

            this.btn_NaechstesNomen.PerformClick();
        }
    }








    public class Nomen
    {
        public string ZuDeutsch;

        public string NominativSingular;
        public string GenitivSingular;
        public string DativSingular;
        public string AkkusativSingular;
        public string AblativSingular;

        public string LokativSingular;
        public string VokativSingular;

        public string NominativPlural;
        public string GenitivPlural;
        public string DativPlural;
        public string AkkusativPlural;
        public string AblativPlural;

        public string LokativPlural;
        public string VokativPlural;


        public void AddLokativ(string singular, string plural)
        {
            this.LokativSingular = singular;
            this.LokativPlural = plural;
        }
        public void AddVokativ(string singular, string plural)
        {
            this.VokativSingular = singular;
            this.VokativPlural = plural;
        }

        public Nomen(string NominativSingular, string GenitivSingular, string DativSingular, string AkkusativSingular, string AblativSingular,
            string NominativPlural, string GenitivPlural, string DativPlural, string AkkusativPlural, string AblativPlural, string ZuDeutsch)
        {
            this.ZuDeutsch = ZuDeutsch;

            this.NominativSingular = NominativSingular;
            this.GenitivSingular = GenitivSingular;
            this.DativSingular = DativSingular;
            this.AkkusativSingular = AkkusativSingular;
            this.AblativSingular = AblativSingular;

            this.NominativPlural = NominativPlural;
            this.GenitivPlural = GenitivPlural;
            this.DativPlural = DativPlural;
            this.AkkusativPlural = AkkusativPlural;
            this.AblativPlural = AblativPlural;
        }
    }
}
