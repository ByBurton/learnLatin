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

        private void nouns_Load(Object sender, EventArgs e)
        {
            this.fillNomensListeFromTextFile();

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

        private void btn_NaechstesNomen_Click(Object sender, EventArgs e)
        {
            this.ausgewaehltesNomen = CollectionExtension.RandomElement(this.NomensListe);

            this.txtBox_NominativSingular.Text = this.ausgewaehltesNomen.NominativSingular;

            this.clearTextBoxes();
        }

        private void clearTextBoxes()
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

        private void btn_LueckenFuellen_Click(Object sender, EventArgs e)
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



        private void saveNomensListeAsTextFile()
        {
            if(!Directory.Exists(@"C:\ProgramData\learnLatin"))
                Directory.CreateDirectory(@"C:\ProgramData\learnLatin");

            FileStream stream = new FileStream(@"C:\ProgramData\learnLatin\Nomen.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);


            foreach(Nomen nomen in this.NomensListe)
            {
                String line = String.Empty;

                String singular = nomen.NominativSingular + ";" + nomen.GenitivSingular + ";" + nomen.DativSingular + ";" + nomen.AkkusativSingular + ";" +
                    nomen.AblativSingular + ";" + nomen.VokativSingular + ";" + nomen.LokativSingular + "#";
                String plural = nomen.NominativPlural + ";" + nomen.GenitivPlural + ";" + nomen.DativPlural + ";" + nomen.AkkusativPlural + ";" + nomen.AblativPlural + ";" + nomen.VokativPlural + ";" + nomen.LokativPlural;

                line = singular + plural + "#" + nomen.ZuDeutsch;

                writer.WriteLine(line);
            }

            writer.Close();
            stream.Close();
        }

        private void fillNomensListeFromTextFile()
        {
            if(!Directory.Exists(@"C:\ProgramData\learnLatin"))
                Directory.CreateDirectory(@"C:\ProgramData\learnLatin");

            if(!File.Exists(@"C:\ProgramData\learnLatin\Nomen.txt"))
                return;

            this.NomensListe.Clear();

            FileStream stream = new FileStream(@"C:\ProgramData\learnLatin\Nomen.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            String line = String.Empty;

            while((line = reader.ReadLine()) != null)
            {
                Nomen nomen = new Nomen(String.Empty, String.Empty, String.Empty, String.Empty, String.Empty, String.Empty, String.Empty, String.Empty,
                    String.Empty, String.Empty, String.Empty);

                String[] singular = line.Split('#')[0].Split(';');
                String[] plural = line.Split('#')[1].Split(';');
                String zuDeutsch = line.Split('#')[2];

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

        private void Nouns_FormClosing(Object sender, FormClosingEventArgs e)
        {
            this.saveNomensListeAsTextFile();
        }

        private void btn_NomenHinzufuegen_Click(Object sender, EventArgs e)
        {
            Nomen nomen = new Nomen(this.txtBox_NominativSingular.Text, this.txtBox_GenitivSingular.Text, this.txtBox_DativSingular.Text, this.txtBox_AkkusativSingular.Text,
                this.txtBox_AblativSingular.Text, this.txtBox_NominativPlural.Text, this.txtBox_GenitivPlural.Text, this.txtBox_DativPlural.Text, this.txtBox_AkkusativPlural.Text,
                this.txtBox_AblativPlural.Text, this.txtBox_ZuDeutsch.Text);

            nomen.AddLokativ(String.Empty, String.Empty);
            nomen.AddVokativ(String.Empty, String.Empty);

            this.NomensListe.Add(nomen);
            nomen = null;

            this.saveNomensListeAsTextFile();

            MessageBox.Show("Das Nomen wurde erfolgreich hinzugefügt!");

            this.btn_NaechstesNomen.PerformClick();
        }
    }








    public class Nomen
    {
        public String ZuDeutsch;

        public String NominativSingular;
        public String GenitivSingular;
        public String DativSingular;
        public String AkkusativSingular;
        public String AblativSingular;

        public String LokativSingular;
        public String VokativSingular;

        public String NominativPlural;
        public String GenitivPlural;
        public String DativPlural;
        public String AkkusativPlural;
        public String AblativPlural;

        public String LokativPlural;
        public String VokativPlural;


        public void AddLokativ(String singular, String plural)
        {
            this.LokativSingular = singular;
            this.LokativPlural = plural;
        }
        public void AddVokativ(String singular, String plural)
        {
            this.VokativSingular = singular;
            this.VokativPlural = plural;
        }

        public Nomen(String NominativSingular, String GenitivSingular, String DativSingular, String AkkusativSingular, String AblativSingular,
            String NominativPlural, String GenitivPlural, String DativPlural, String AkkusativPlural, String AblativPlural, String ZuDeutsch)
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
