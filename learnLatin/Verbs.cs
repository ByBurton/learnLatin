//-------------------------------------------------------------------------------------------------
//Author: Maederer
//Company: page one GmbH
//Created: December, 14th, 2017
//File: Verbs.cs
//Short Description: verb learning
//-------------------------------------------------------------------------------------------------


using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace learnLatin
{
    public partial class Verbs : Form
    {
        public List<Verb> VerbenListe = new List<Verb>();
        private Verb ausgewaehltesVerb;

        public Verbs()
        {
            InitializeComponent();
        }

        private void btn_NaechstesVerb_Click(Object sender, EventArgs e)
        {
            this.ausgewaehltesVerb = CollectionExtension.RandomElement(this.VerbenListe);

            this.txtBox_Infinitiv.Text = this.ausgewaehltesVerb.Infinitiv;
        }

        private void btn_LueckenFuellen_Click(Object sender, EventArgs e)
        {
            //Indikativ
            //Praesens
            this.txtBox_ErstePersonSingularPraesensIndikativ.Text = this.ausgewaehltesVerb.ErstePersonSingularPraesensIndikativ;
            this.txtBox_ErstePersonPluralPraesensIndikativ.Text = this.ausgewaehltesVerb.ErstePersonPluralPraesensIndikativ;
            this.txtBox_ZweitePersonSingularPraesensIndikativ.Text = this.ausgewaehltesVerb.ZweitePersonSingularPraesensIndikativ;
            this.txtBox_ZweitePersonPluralPraesensIndikativ.Text = this.ausgewaehltesVerb.ZweitePersonPluralPraesensIndikativ;
            this.txtBox_DrittePersonSingularPraesensIndikativ.Text = this.ausgewaehltesVerb.DrittePersonSingularPraesensIndikativ;
            this.txtBox_DrittePersonPluralPraesensIndikativ.Text = this.ausgewaehltesVerb.DrittePersonPluralPraesensIndikativ;

            //Perfekt
            this.txtBox_ErstePersonSingularPerfektIndikativ.Text = this.ausgewaehltesVerb.ErstePersonSingularPerfektIndikativ;
            this.txtBox_ErstePersonPluralPerfektIndikativ.Text = this.ausgewaehltesVerb.ErstePersonPluralPerfektIndikativ;
            this.txtBox_ZweitePersonSingularPerfektIndikativ.Text = this.ausgewaehltesVerb.ZweitePersonSingularPerfektIndikativ;
            this.txtBox_ZweitePersonPluralPerfektIndikativ.Text = this.ausgewaehltesVerb.ZweitePersonPluralPerfektIndikativ;
            this.txtBox_DrittePersonSingularPerfektIndikativ.Text = this.ausgewaehltesVerb.DrittePersonSingularPerfektIndikativ;
            this.txtBox_DrittePersonPluralPerfektIndikativ.Text = this.ausgewaehltesVerb.DrittePersonPluralPerfektIndikativ;

            //Imperfekt
            this.txtBox_ErstePersonSingularImperfektIndikativ.Text = this.ausgewaehltesVerb.ErstePersonSingularImperfektIndikativ;
            this.txtBox_ErstePersonPluralImperfektIndikativ.Text = this.ausgewaehltesVerb.ErstePersonPluralImperfektIndikativ;
            this.txtBox_ZweitePersonSingularImperfektIndikativ.Text = this.ausgewaehltesVerb.ZweitePersonSingularImperfektIndikativ;
            this.txtBox_ZweitePersonPluralImperfektIndikativ.Text = this.ausgewaehltesVerb.ZweitePersonPluralImperfektIndikativ;
            this.txtBox_DrittePersonSingularImperfektIndikativ.Text = this.ausgewaehltesVerb.DrittePersonSingularImperfektIndikativ;
            this.txtBox_DrittePersonPluralImperfektIndikativ.Text = this.ausgewaehltesVerb.DrittePersonPluralImperfektIndikativ;

            //Plusquamperfekt
            this.txtBox_ErstePersonSingularPlusquamperfektIndikativ.Text = this.ausgewaehltesVerb.ErstePersonSingularPlusquamperfektIndikativ;
            this.txtBox_ErstePersonPluralPlusquamperfektIndikativ.Text = this.ausgewaehltesVerb.ErstePersonPluralPlusquamperfektIndikativ;
            this.txtBox_ZweitePersonSingularPlusquamperfektIndikativ.Text = this.ausgewaehltesVerb.ZweitePersonSingularPlusquamperfektIndikativ;
            this.txtBox_ZweitePersonPluralPlusquamperfektIndikativ.Text = this.ausgewaehltesVerb.ZweitePersonPluralPlusquamperfektIndikativ;
            this.txtBox_DrittePersonSingularPlusquamperfektIndikativ.Text = this.ausgewaehltesVerb.DrittePersonSingularPlusquamperfektIndikativ;
            this.txtBox_DrittePersonPluralPlusquamperfektIndikativ.Text = this.ausgewaehltesVerb.DrittePersonPluralPlusquamperfektIndikativ;

            //Futur I
            this.txtBox_ErstePersonSingularFutur_IImperfekt.Text = this.ausgewaehltesVerb.ErstePersonSingularFutur_I_Indikativ;
            this.txtBox_ErstePersonPluralFutur_IIndikativ.Text = this.ausgewaehltesVerb.ErstePersonPluralFutur_I_Indikativ;
            this.txtBox_ZweitePersonSingularFutur_IIndikativ.Text = this.ausgewaehltesVerb.ZweitePersonSingularFutur_I_Indikativ;
            this.txtBox_ZweitePersonPluralFutur_IIndikativ.Text = this.ausgewaehltesVerb.ZweitePersonPluralFutur_I_Indikativ;
            this.txtBox_DrittePersonSingularFutur_IIndikativ.Text = this.ausgewaehltesVerb.DrittePersonSingularFutur_I_Indikativ;
            this.txtBox_DrittePersonPluralFutur_IIndikativ.Text = this.ausgewaehltesVerb.DrittePersonPluralFutur_I_Indikativ;

            //Futur II
            this.txtBox_ErstePersonSingularFutur_IIIndikativ.Text = this.ausgewaehltesVerb.ErstePersonSingularFutur_II_Indikativ;
            this.txtBox_ErstePersonPluralFutur_IIIndikativ.Text = this.ausgewaehltesVerb.ErstePersonPluralFutur_II_Indikativ;
            this.txtBox_ZweitePersonSingularFutur_IIIndikativ.Text = this.ausgewaehltesVerb.ZweitePersonSingularFutur_II_Indikativ;
            this.txtBox_ZweitePersonPluralFutur_IIIndikativ.Text = this.ausgewaehltesVerb.ZweitePersonPluralFutur_II_Indikativ;
            this.txtBox_DrittePersonSingularFutur_IIIndikativ.Text = this.ausgewaehltesVerb.DrittePersonSingularFutur_II_Indikativ;
            this.txtBox_DrittePersonPluralFutur_IIIndikativ.Text = this.ausgewaehltesVerb.DrittePersonPluralFutur_II_Indikativ;

            //Konjunktiv
            //Praesens
            this.txtBox_ErstePersonSingularPraesensKonjunktiv.Text = this.ausgewaehltesVerb.ErstePersonSingularPraesensKonjunktiv;
            this.txtBox_ErstePersonPluralPraesensKonjunktiv.Text = this.ausgewaehltesVerb.ErstePersonPluralPraesensKonjunktiv;
            this.txtBox_ZweitePersonSingularPraesensKonjunktiv.Text = this.ausgewaehltesVerb.ZweitePersonSingularPraesensKonjunktiv;
            this.txtBox_ZweitePersonPluralPraesensKonjunktiv.Text = this.ausgewaehltesVerb.ZweitePersonPluralPraesensKonjunktiv;
            this.txtBox_DrittePersonSingularPraesensKonjunktiv.Text = this.ausgewaehltesVerb.DrittePersonSingularPraesensKonjunktiv;
            this.txtBox_DrittePersonPluralPraesensKonjunktiv.Text = this.ausgewaehltesVerb.DrittePersonPluralPraesensKonjunktiv;

            //Perfekt
            this.txtBox_ErstePersonSingularPerfektKonjunktiv.Text = this.ausgewaehltesVerb.ErstePersonSingularPerfektKonjunktiv;
            this.txtBox_ErstePersonPluralPerfektKonjunktiv.Text = this.ausgewaehltesVerb.ErstePersonPluralPerfektKonjunktiv;
            this.txtBox_ZweitePersonSingularPerfektKonjunktiv.Text = this.ausgewaehltesVerb.ZweitePersonSingularPerfektKonjunktiv;
            this.txtBox_ZweitePersonPluralPerfektKonjunktiv.Text = this.ausgewaehltesVerb.ZweitePersonPluralPerfektKonjunktiv;
            this.txtBox_DrittePersonSingularPerfektKonjunktiv.Text = this.ausgewaehltesVerb.DrittePersonSingularPerfektKonjunktiv;
            this.txtBox_DrittePersonPluralPerfektKonjunktiv.Text = this.ausgewaehltesVerb.DrittePersonPluralPerfektKonjunktiv;

            //Imperfekt
            this.txtBox_ErstePersonSingularImperfektKonjunktiv.Text = this.ausgewaehltesVerb.ErstePersonSingularImperfektKonjunktiv;
            this.txtBox_ErstePersonPluralImperfektKonjunktiv.Text = this.ausgewaehltesVerb.ErstePersonPluralImperfektKonjunktiv;
            this.txtBox_ZweitePersonSingularImperfektKonjunktiv.Text = this.ausgewaehltesVerb.ZweitePersonSingularImperfektKonjunktiv;
            this.txtBox_ZweitePersonPluralImperfektKonjunktiv.Text = this.ausgewaehltesVerb.ZweitePersonPluralImperfektKonjunktiv;
            this.txtBox_DrittePersonSingularImperfektKonjunktiv.Text = this.ausgewaehltesVerb.DrittePersonSingularImperfektKonjunktiv;
            this.txtBox_DrittePersonPluralImperfektKonjunktiv.Text = this.ausgewaehltesVerb.DrittePersonPluralImperfektKonjunktiv;

            //Plusquamperfekt
            this.txtBox_ErstePersonSingularPlusquamperfektKonjunktiv.Text = this.ausgewaehltesVerb.ErstePersonSingularPlusquamperfektKonjunktiv;
            this.txtBox_ErstePersonPluralPlusquamperfektKonjunktiv.Text = this.ausgewaehltesVerb.ErstePersonPluralPlusquamperfektKonjunktiv;
            this.txtBox_ZweitePersonSingularPlusquamperfektKonjunktiv.Text = this.ausgewaehltesVerb.ZweitePersonSingularPlusquamperfektKonjunktiv;
            this.txtBox_ZweitePersonPluralPlusquamperfektKonjunktiv.Text = this.ausgewaehltesVerb.ZweitePersonPluralPlusquamperfektKonjunktiv;
            this.txtBox_DrittePersonSingularPlusquamperfektKonjunktiv.Text = this.ausgewaehltesVerb.DrittePersonSingularPlusquamperfektKonjunktiv;
            this.txtBox_DrittePersonPluralPlusquamperfektKonjunktiv.Text = this.ausgewaehltesVerb.DrittePersonPluralPlusquamperfektKonjunktiv;
        }

        public void FillVerbenListe()
        {
            /*this.VerbenListe.Add(new Verb("properare"));
            this.VerbenListe[0].SetPraesensIndikativ("propero", "peroperas", "properat", "properamus", "properatis", "properant");
            this.VerbenListe[0].SetPerfektIndikativ("properavi", "properavisti", "properavit", "properavimus", "properavisti", "properaverunt");
            this.VerbenListe[0].SetImperfektIndikativ("properabam", "properabas", "properabat", "properabamus", "properabatis", "properabant");
            this.VerbenListe[0].SetPlusquamperfektIndikativ("properaveram", "properaveras", "properaverat", "properaveramus", "properaveratis", "properaverant");
            this.VerbenListe[0].SetFutur_I_Indikativ("properabo", "proberabis", "properabit", "properabimus", "properabitis", "properabunt");
            this.VerbenListe[0].SetFutur_II_Indikativ("properavero", "properaveris", "properaverit", "properavimus", "properabitis", "properaverint");
            this.VerbenListe[0].SetPraesensKonjunktiv("properem", "properes", "properet", "properemus", "properetis", "properent");
            this.VerbenListe[0].SetPerfektKonjunktiv("properaverim", "properaveris", "properaveret", "properemus", "properetis", "properent");
            this.VerbenListe[0].SetImperfektKonjunktiv("properarem", "properares", "properaret", "properaremus", "properaretis", "properarent");
            this.VerbenListe[0].SetPlusquamperfektKonjunktiv("properavissem", "properavisses", "properavisset", "properavissemus", "properavissetis", "properavissent");*/
        }

        private void saveVerbenListeAsTextFile()
        {
            if(!Directory.Exists(@"C:\ProgramData\learnLatin"))
                Directory.CreateDirectory(@"C:\ProgramData\learnLatin");


            FileStream stream = new FileStream(@"C:\ProgramData\learnLatin\Verben.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);

            foreach(Verb verb in this.VerbenListe)
            {
                String line = String.Empty;

                String indikativ = verb.Infinitiv + "|" + verb.ErstePersonSingularPraesensIndikativ + ";" + verb.ErstePersonPluralPraesensIndikativ + ";" +
                    verb.ZweitePersonSingularPraesensIndikativ + ";" + verb.ZweitePersonPluralPraesensIndikativ + ";" + verb.DrittePersonSingularPraesensIndikativ + ";" +
                    verb.DrittePersonPluralPraesensIndikativ + "#" + verb.ErstePersonSingularPerfektIndikativ + ";" + verb.ErstePersonPluralPerfektIndikativ + ";" +
                    verb.ZweitePersonSingularPerfektIndikativ + ";" + verb.ZweitePersonPluralPerfektIndikativ + ";" + verb.DrittePersonSingularPerfektIndikativ + ";" +
                    verb.DrittePersonPluralPerfektIndikativ + "#" + verb.ErstePersonSingularImperfektIndikativ + ";" + verb.ErstePersonPluralImperfektIndikativ + ";" +
                    verb.ZweitePersonSingularImperfektIndikativ + ";" + verb.ZweitePersonPluralImperfektIndikativ + ";" + verb.DrittePersonSingularImperfektIndikativ + ";" +
                    verb.DrittePersonPluralImperfektIndikativ + "#" + verb.ErstePersonSingularPlusquamperfektIndikativ + ";" + verb.ErstePersonPluralPlusquamperfektIndikativ + ";" +
                    verb.ZweitePersonSingularPlusquamperfektIndikativ + ";" + verb.ZweitePersonPluralPlusquamperfektIndikativ + ";" + verb.DrittePersonSingularPlusquamperfektIndikativ + ";" +
                    verb.DrittePersonPluralPlusquamperfektIndikativ + "#" + verb.ErstePersonSingularFutur_I_Indikativ + ";" + verb.ErstePersonPluralFutur_I_Indikativ + ";" +
                    verb.ZweitePersonSingularFutur_I_Indikativ + ";" + verb.ZweitePersonPluralFutur_I_Indikativ + ";" + verb.DrittePersonSingularFutur_I_Indikativ + ";" +
                    verb.DrittePersonPluralFutur_I_Indikativ + "#" + verb.ErstePersonSingularFutur_II_Indikativ + ";" + verb.ErstePersonPluralFutur_II_Indikativ + ";" +
                    verb.ZweitePersonSingularFutur_II_Indikativ + ";" + verb.ZweitePersonPluralFutur_II_Indikativ + ";" + verb.DrittePersonSingularFutur_II_Indikativ + ";" +
                    verb.DrittePersonPluralFutur_II_Indikativ + "|";

                String konjunktiv = verb.ErstePersonSingularPraesensKonjunktiv + ";" + verb.ErstePersonPluralPraesensKonjunktiv + ";" +
                    verb.ZweitePersonSingularPraesensKonjunktiv + ";" + verb.ZweitePersonPluralPraesensKonjunktiv + ";" + verb.DrittePersonSingularPraesensKonjunktiv + ";" +
                    verb.DrittePersonPluralPraesensKonjunktiv + "#" + verb.ErstePersonSingularPerfektKonjunktiv + ";" + verb.ErstePersonPluralPerfektKonjunktiv + ";" +
                    verb.ZweitePersonSingularPerfektKonjunktiv + ";" + verb.ZweitePersonPluralPerfektKonjunktiv + ";" + verb.DrittePersonSingularPerfektKonjunktiv + ";" +
                    verb.DrittePersonPluralPerfektKonjunktiv + "#" + verb.ErstePersonSingularImperfektKonjunktiv + ";" + verb.ErstePersonPluralImperfektKonjunktiv + ";" +
                    verb.ZweitePersonSingularImperfektKonjunktiv + ";" + verb.ZweitePersonPluralImperfektKonjunktiv + ";" + verb.DrittePersonSingularImperfektKonjunktiv + ";" +
                    verb.DrittePersonPluralImperfektKonjunktiv + "#" + verb.ErstePersonSingularPlusquamperfektKonjunktiv + ";" + verb.ErstePersonPluralPlusquamperfektKonjunktiv + ";" +
                    verb.ZweitePersonSingularPlusquamperfektKonjunktiv + ";" + verb.ZweitePersonPluralPlusquamperfektKonjunktiv + ";" + verb.DrittePersonSingularPlusquamperfektKonjunktiv + ";" +
                    verb.DrittePersonPluralPlusquamperfektKonjunktiv;

                line = indikativ + konjunktiv;

                writer.WriteLine(line);
            }

            writer.Close();
            stream.Close();
        }

        private void fillVerbenListeFromTextFile()
        {
            if(!Directory.Exists(@"C:\ProgramData\learnLatin"))
                Directory.CreateDirectory(@"C:\ProgramData\learnLatin");

            if(!File.Exists(@"C:\ProgramData\learnLatin\Verben.txt"))
                return;

            this.VerbenListe.Clear();

            FileStream stream = new FileStream(@"C:\ProgramData\learnLatin\Verben.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            String line;
            Verb verb;



            while((line = reader.ReadLine()) != null)
            {
                String infinitiv = line.Split('|')[0];
                String indikativString = line.Split('|')[1];
                String konjunktivString = line.Split('|')[2];

                verb = new Verb(infinitiv);

                String praesens = indikativString.Split('#')[0];
                String perfekt = indikativString.Split('#')[1];
                String imperfekt = indikativString.Split('#')[2];
                String plusquamperfekt = indikativString.Split('#')[3];
                String futur_I = indikativString.Split('#')[4];
                String futur_II = indikativString.Split('#')[5];

                verb.SetPraesensIndikativ(praesens.Split(';')[0], praesens.Split(';')[1], praesens.Split(';')[2], praesens.Split(';')[3], praesens.Split(';')[4],
                    praesens.Split(';')[5]);
                verb.SetPerfektIndikativ(perfekt.Split(';')[0], perfekt.Split(';')[1], perfekt.Split(';')[2], perfekt.Split(';')[3], perfekt.Split(';')[4], perfekt.Split(';')[5]);
                verb.SetImperfektIndikativ(imperfekt.Split(';')[0], imperfekt.Split(';')[1], imperfekt.Split(';')[2], imperfekt.Split(';')[3], imperfekt.Split(';')[4],
                    imperfekt.Split(';')[5]);
                verb.SetPlusquamperfektIndikativ(plusquamperfekt.Split(';')[0], plusquamperfekt.Split(';')[1], plusquamperfekt.Split(';')[2], plusquamperfekt.Split(';')[3], 
                    plusquamperfekt.Split(';')[4], plusquamperfekt.Split(';')[5]);
                verb.SetFutur_I_Indikativ(futur_I.Split(';')[0], futur_I.Split(';')[1], futur_I.Split(';')[2], futur_I.Split(';')[3], futur_I.Split(';')[4], futur_I.Split(';')[5]);
                verb.SetFutur_II_Indikativ(futur_II.Split(';')[0], futur_II.Split(';')[1], futur_II.Split(';')[2], futur_II.Split(';')[3], futur_II.Split(';')[4], futur_II.Split(';')[5]);

                praesens = konjunktivString.Split('#')[0];
                perfekt = konjunktivString.Split('#')[1];
                imperfekt = konjunktivString.Split('#')[2];
                plusquamperfekt = konjunktivString.Split('#')[3];

                verb.SetPraesensKonjunktiv(praesens.Split(';')[0], praesens.Split(';')[1], praesens.Split(';')[2], praesens.Split(';')[3], praesens.Split(';')[4],
                    praesens.Split(';')[5]);
                verb.SetPerfektKonjunktiv(perfekt.Split(';')[0], perfekt.Split(';')[1], perfekt.Split(';')[2], perfekt.Split(';')[3], perfekt.Split(';')[4], perfekt.Split(';')[5]);
                verb.SetImperfektKonjunktiv(imperfekt.Split(';')[0], imperfekt.Split(';')[1], imperfekt.Split(';')[2], imperfekt.Split(';')[3], imperfekt.Split(';')[4],
                    imperfekt.Split(';')[5]);
                verb.SetPlusquamperfektKonjunktiv(plusquamperfekt.Split(';')[0], plusquamperfekt.Split(';')[1], plusquamperfekt.Split(';')[2], plusquamperfekt.Split(';')[3],
                    plusquamperfekt.Split(';')[4], plusquamperfekt.Split(';')[5]);



                this.VerbenListe.Add(verb);
            }

            reader.Close();
            stream.Close();
        }

        private void Verbs_Load(Object sender, EventArgs e)
        {
            this.fillVerbenListeFromTextFile();

            if(this.VerbenListe.Count== 0)
                FillVerbenListe();

            this.btn_NaechstesVerb.PerformClick();
        }

        private void Verbs_FormClosing(Object sender, FormClosingEventArgs e)
        {
            this.saveVerbenListeAsTextFile();
        }
    }












    public class Verb
    {
        public String Infinitiv;

        //Indikativ
        //Praesens
        public String ErstePersonSingularPraesensIndikativ;
        public String ErstePersonPluralPraesensIndikativ;
        public String ZweitePersonSingularPraesensIndikativ;
        public String ZweitePersonPluralPraesensIndikativ;
        public String DrittePersonSingularPraesensIndikativ;
        public String DrittePersonPluralPraesensIndikativ;

        //Perfekt
        public String ErstePersonSingularPerfektIndikativ;
        public String ErstePersonPluralPerfektIndikativ;
        public String ZweitePersonSingularPerfektIndikativ;
        public String ZweitePersonPluralPerfektIndikativ;
        public String DrittePersonSingularPerfektIndikativ;
        public String DrittePersonPluralPerfektIndikativ;

        //Imperfekt
        public String ErstePersonSingularImperfektIndikativ;
        public String ErstePersonPluralImperfektIndikativ;
        public String ZweitePersonSingularImperfektIndikativ;
        public String ZweitePersonPluralImperfektIndikativ;
        public String DrittePersonSingularImperfektIndikativ;
        public String DrittePersonPluralImperfektIndikativ;

        //Plusquamperfekt
        public String ErstePersonSingularPlusquamperfektIndikativ;
        public String ErstePersonPluralPlusquamperfektIndikativ;
        public String ZweitePersonSingularPlusquamperfektIndikativ;
        public String ZweitePersonPluralPlusquamperfektIndikativ;
        public String DrittePersonSingularPlusquamperfektIndikativ;
        public String DrittePersonPluralPlusquamperfektIndikativ;

        //Futur I
        public String ErstePersonSingularFutur_I_Indikativ;
        public String ErstePersonPluralFutur_I_Indikativ;
        public String ZweitePersonSingularFutur_I_Indikativ;
        public String ZweitePersonPluralFutur_I_Indikativ;
        public String DrittePersonSingularFutur_I_Indikativ;
        public String DrittePersonPluralFutur_I_Indikativ;

        //Futur II
        public String ErstePersonSingularFutur_II_Indikativ;
        public String ErstePersonPluralFutur_II_Indikativ;
        public String ZweitePersonSingularFutur_II_Indikativ;
        public String ZweitePersonPluralFutur_II_Indikativ;
        public String DrittePersonSingularFutur_II_Indikativ;
        public String DrittePersonPluralFutur_II_Indikativ;


        //Konjunktiv
        //Praesens
        public String ErstePersonSingularPraesensKonjunktiv;
        public String ErstePersonPluralPraesensKonjunktiv;
        public String ZweitePersonSingularPraesensKonjunktiv;
        public String ZweitePersonPluralPraesensKonjunktiv;
        public String DrittePersonSingularPraesensKonjunktiv;
        public String DrittePersonPluralPraesensKonjunktiv;

        //Perfekt
        public String ErstePersonSingularPerfektKonjunktiv;
        public String ErstePersonPluralPerfektKonjunktiv;
        public String ZweitePersonSingularPerfektKonjunktiv;
        public String ZweitePersonPluralPerfektKonjunktiv;
        public String DrittePersonSingularPerfektKonjunktiv;
        public String DrittePersonPluralPerfektKonjunktiv;

        //Imperfekt
        public String ErstePersonSingularImperfektKonjunktiv;
        public String ErstePersonPluralImperfektKonjunktiv;
        public String ZweitePersonSingularImperfektKonjunktiv;
        public String ZweitePersonPluralImperfektKonjunktiv;
        public String DrittePersonSingularImperfektKonjunktiv;
        public String DrittePersonPluralImperfektKonjunktiv;

        //Plusquamperfekt
        public String ErstePersonSingularPlusquamperfektKonjunktiv;
        public String ErstePersonPluralPlusquamperfektKonjunktiv;
        public String ZweitePersonSingularPlusquamperfektKonjunktiv;
        public String ZweitePersonPluralPlusquamperfektKonjunktiv;
        public String DrittePersonSingularPlusquamperfektKonjunktiv;
        public String DrittePersonPluralPlusquamperfektKonjunktiv; 

        public void SetPraesensIndikativ(String ErstePersonSingular, String ErstePersonPlural, String ZweitePersonSingular, String ZweitePersonPlural,
            String DrittePersonSingular, String DrittePersonPlural)
        {
            this.ErstePersonSingularPraesensIndikativ = ErstePersonSingular;
            this.ErstePersonPluralPraesensIndikativ = ErstePersonPlural;
            this.ZweitePersonSingularPraesensIndikativ = ZweitePersonSingular;
            this.ZweitePersonPluralPraesensIndikativ = ZweitePersonPlural;
            this.DrittePersonSingularPraesensIndikativ = DrittePersonSingular;
            this.DrittePersonPluralPraesensIndikativ = DrittePersonPlural;
        }

        public void SetPerfektIndikativ(String ErstePersonSingular, String ErstePersonPlural, String ZweitePersonSingular, String ZweitePersonPlural,
            String DrittePersonSingular, String DrittePersonPlural)
        {
            this.ErstePersonSingularPerfektIndikativ = ErstePersonSingular;
            this.ErstePersonPluralPerfektIndikativ = ErstePersonPlural;
            this.ZweitePersonSingularPerfektIndikativ = ZweitePersonSingular;
            this.ZweitePersonPluralPerfektIndikativ = ZweitePersonPlural;
            this.DrittePersonSingularPerfektIndikativ = DrittePersonSingular;
            this.DrittePersonPluralPerfektIndikativ = DrittePersonPlural;
        }

        public void SetImperfektIndikativ(String ErstePersonSingular, String ErstePersonPlural, String ZweitePersonSingular, String ZweitePersonPlural,
            String DrittePersonSingular, String DrittePersonPlural)
        {
            this.ErstePersonSingularImperfektIndikativ = ErstePersonSingular;
            this.ErstePersonPluralImperfektIndikativ = ErstePersonPlural;
            this.ZweitePersonSingularImperfektIndikativ = ZweitePersonSingular;
            this.ZweitePersonPluralImperfektIndikativ = ZweitePersonPlural;
            this.DrittePersonSingularImperfektIndikativ = DrittePersonSingular;
            this.DrittePersonPluralImperfektIndikativ = DrittePersonPlural;
        }

        public void SetPlusquamperfektIndikativ(String ErstePersonSingular, String ErstePersonPlural, String ZweitePersonSingular, String ZweitePersonPlural,
            String DrittePersonSingular, String DrittePersonPlural)
        {
            this.ErstePersonSingularPlusquamperfektIndikativ = ErstePersonSingular;
            this.ErstePersonPluralPlusquamperfektIndikativ = ErstePersonPlural;
            this.ZweitePersonSingularPlusquamperfektIndikativ = ZweitePersonSingular;
            this.ZweitePersonPluralPlusquamperfektIndikativ = ZweitePersonPlural;
            this.DrittePersonSingularPlusquamperfektIndikativ = DrittePersonSingular;
            this.DrittePersonPluralPlusquamperfektIndikativ = DrittePersonPlural;
        }

        public void SetFutur_I_Indikativ(String ErstePersonSingular, String ErstePersonPlural, String ZweitePersonSingular, String ZweitePersonPlural,
            String DrittePersonSingular, String DrittePersonPlural)
        {
            this.ErstePersonSingularFutur_I_Indikativ = ErstePersonSingular;
            this.ErstePersonPluralFutur_I_Indikativ = ErstePersonPlural;
            this.ZweitePersonSingularFutur_I_Indikativ = ZweitePersonSingular;
            this.ZweitePersonPluralFutur_I_Indikativ = ZweitePersonPlural;
            this.DrittePersonSingularFutur_I_Indikativ = DrittePersonSingular;
            this.DrittePersonPluralFutur_I_Indikativ = DrittePersonPlural;
        }

        public void SetFutur_II_Indikativ(String ErstePersonSingular, String ErstePersonPlural, String ZweitePersonSingular, String ZweitePersonPlural,
            String DrittePersonSingular, String DrittePersonPlural)
        {
            this.ErstePersonSingularFutur_II_Indikativ = ErstePersonSingular;
            this.ErstePersonPluralFutur_II_Indikativ = ErstePersonPlural;
            this.ZweitePersonSingularFutur_II_Indikativ = ZweitePersonSingular;
            this.ZweitePersonPluralFutur_II_Indikativ = ZweitePersonPlural;
            this.DrittePersonSingularFutur_II_Indikativ = DrittePersonSingular;
            this.DrittePersonPluralFutur_II_Indikativ = DrittePersonPlural;
        }

        public void SetPraesensKonjunktiv(String ErstePersonSingular, String ErstePersonPlural, String ZweitePersonSingular, String ZweitePersonPlural,
            String DrittePersonSingular, String DrittePersonPlural)
        {
            this.ErstePersonSingularPraesensKonjunktiv = ErstePersonSingular;
            this.ErstePersonPluralPraesensKonjunktiv = ErstePersonPlural;
            this.ZweitePersonSingularPraesensKonjunktiv = ZweitePersonSingular;
            this.ZweitePersonPluralPraesensKonjunktiv = ZweitePersonPlural;
            this.DrittePersonSingularPraesensKonjunktiv = DrittePersonSingular;
            this.DrittePersonPluralPraesensKonjunktiv = DrittePersonPlural;
        }

        public void SetPerfektKonjunktiv(String ErstePersonSingular, String ErstePersonPlural, String ZweitePersonSingular, String ZweitePersonPlural,
            String DrittePersonSingular, String DrittePersonPlural)
        {
            this.ErstePersonSingularPerfektKonjunktiv = ErstePersonSingular;
            this.ErstePersonPluralPerfektKonjunktiv = ErstePersonPlural;
            this.ZweitePersonSingularPerfektKonjunktiv = ZweitePersonSingular;
            this.ZweitePersonPluralPerfektKonjunktiv = ZweitePersonPlural;
            this.DrittePersonSingularPerfektKonjunktiv = DrittePersonSingular;
            this.DrittePersonPluralPerfektKonjunktiv = DrittePersonPlural;
        }

        public void SetImperfektKonjunktiv(String ErstePersonSingular, String ErstePersonPlural, String ZweitePersonSingular, String ZweitePersonPlural,
            String DrittePersonSingular, String DrittePersonPlural)
        {
            this.ErstePersonSingularImperfektKonjunktiv = ErstePersonSingular;
            this.ErstePersonPluralImperfektKonjunktiv = ErstePersonPlural;
            this.ZweitePersonSingularImperfektKonjunktiv = ZweitePersonSingular;
            this.ZweitePersonPluralImperfektKonjunktiv = ZweitePersonPlural;
            this.DrittePersonSingularImperfektKonjunktiv = DrittePersonSingular;
            this.DrittePersonPluralImperfektKonjunktiv = DrittePersonPlural;
        }

        public void SetPlusquamperfektKonjunktiv(String ErstePersonSingular, String ErstePersonPlural, String ZweitePersonSingular, String ZweitePersonPlural,
            String DrittePersonSingular, String DrittePersonPlural)
        {
            this.ErstePersonSingularPlusquamperfektKonjunktiv = ErstePersonSingular;
            this.ErstePersonPluralPlusquamperfektKonjunktiv = ErstePersonPlural;
            this.ZweitePersonSingularPlusquamperfektKonjunktiv = ZweitePersonSingular;
            this.ZweitePersonPluralPlusquamperfektKonjunktiv = ZweitePersonPlural;
            this.DrittePersonSingularPlusquamperfektKonjunktiv = DrittePersonSingular;
            this.DrittePersonPluralPlusquamperfektKonjunktiv = DrittePersonPlural;
        }


        public Verb(String Infinitiv)
        {
            this.Infinitiv = Infinitiv;
        }
    }
}
