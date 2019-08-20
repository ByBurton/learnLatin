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

        private void Btn_NaechstesVerb_Click(object sender, EventArgs e)
        {
            this.ausgewaehltesVerb = CollectionExtension.RandomElement(this.VerbenListe);

            this.txtBox_Infinitiv.Text = this.ausgewaehltesVerb.Infinitiv;

            this.ClearTextBoxes();
        }

        private void ClearTextBoxes()
        {
            this.txtBox_ZuDeutsch.Text = String.Empty;

            //Indikativ
            //Praesens
            this.txtBox_ErstePersonSingularPraesensIndikativ.Text = String.Empty;
            this.txtBox_ErstePersonPluralPraesensIndikativ.Text = String.Empty;
            this.txtBox_ZweitePersonSingularPraesensIndikativ.Text = String.Empty;
            this.txtBox_ZweitePersonPluralPraesensIndikativ.Text = String.Empty;
            this.txtBox_DrittePersonSingularPraesensIndikativ.Text = String.Empty;
            this.txtBox_DrittePersonPluralPraesensIndikativ.Text = String.Empty;

            //Perfekt
            this.txtBox_ErstePersonSingularPerfektIndikativ.Text = String.Empty;
            this.txtBox_ErstePersonPluralPerfektIndikativ.Text = String.Empty;
            this.txtBox_ZweitePersonSingularPerfektIndikativ.Text = String.Empty;
            this.txtBox_ZweitePersonPluralPerfektIndikativ.Text = String.Empty;
            this.txtBox_DrittePersonSingularPerfektIndikativ.Text = String.Empty;
            this.txtBox_DrittePersonPluralPerfektIndikativ.Text = String.Empty;

            //Imperfekt
            this.txtBox_ErstePersonSingularImperfektIndikativ.Text = String.Empty;
            this.txtBox_ErstePersonPluralImperfektIndikativ.Text = String.Empty;
            this.txtBox_ZweitePersonSingularImperfektIndikativ.Text = String.Empty;
            this.txtBox_ZweitePersonPluralImperfektIndikativ.Text = String.Empty;
            this.txtBox_DrittePersonSingularImperfektIndikativ.Text = String.Empty;
            this.txtBox_DrittePersonPluralImperfektIndikativ.Text = String.Empty;

            //Plusquamperfekt
            this.txtBox_ErstePersonSingularPlusquamperfektIndikativ.Text = String.Empty;
            this.txtBox_ErstePersonPluralPlusquamperfektIndikativ.Text = String.Empty;
            this.txtBox_ZweitePersonSingularPlusquamperfektIndikativ.Text = String.Empty;
            this.txtBox_ZweitePersonPluralPlusquamperfektIndikativ.Text = String.Empty;
            this.txtBox_DrittePersonSingularPlusquamperfektIndikativ.Text = String.Empty;
            this.txtBox_DrittePersonPluralPlusquamperfektIndikativ.Text = String.Empty;

            //Futur I
            this.txtBox_ErstePersonSingularFutur_IIndikativ.Text = String.Empty;
            this.txtBox_ErstePersonPluralFutur_IIndikativ.Text = String.Empty;
            this.txtBox_ZweitePersonSingularFutur_IIndikativ.Text = String.Empty;
            this.txtBox_ZweitePersonPluralFutur_IIndikativ.Text = String.Empty;
            this.txtBox_DrittePersonSingularFutur_IIndikativ.Text = String.Empty;
            this.txtBox_DrittePersonPluralFutur_IIndikativ.Text = String.Empty;

            //Futur II
            this.txtBox_ErstePersonSingularFutur_IIIndikativ.Text = String.Empty;
            this.txtBox_ErstePersonPluralFutur_IIIndikativ.Text = String.Empty;
            this.txtBox_ZweitePersonSingularFutur_IIIndikativ.Text = String.Empty;
            this.txtBox_ZweitePersonPluralFutur_IIIndikativ.Text = String.Empty;
            this.txtBox_DrittePersonSingularFutur_IIIndikativ.Text = String.Empty;
            this.txtBox_DrittePersonPluralFutur_IIIndikativ.Text = String.Empty;

            //Konjunktiv
            //Praesens
            this.txtBox_ErstePersonSingularPraesensKonjunktiv.Text = String.Empty;
            this.txtBox_ErstePersonPluralPraesensKonjunktiv.Text = String.Empty;
            this.txtBox_ZweitePersonSingularPraesensKonjunktiv.Text = String.Empty;
            this.txtBox_ZweitePersonPluralPraesensKonjunktiv.Text = String.Empty;
            this.txtBox_DrittePersonSingularPraesensKonjunktiv.Text = String.Empty;
            this.txtBox_DrittePersonPluralPraesensKonjunktiv.Text = String.Empty;

            //Perfekt
            this.txtBox_ErstePersonSingularPerfektKonjunktiv.Text = String.Empty;
            this.txtBox_ErstePersonPluralPerfektKonjunktiv.Text = String.Empty;
            this.txtBox_ZweitePersonSingularPerfektKonjunktiv.Text = String.Empty;
            this.txtBox_ZweitePersonPluralPerfektKonjunktiv.Text = String.Empty;
            this.txtBox_DrittePersonSingularPerfektKonjunktiv.Text = String.Empty;
            this.txtBox_DrittePersonPluralPerfektKonjunktiv.Text = String.Empty;

            //Imperfekt
            this.txtBox_ErstePersonSingularImperfektKonjunktiv.Text = String.Empty;
            this.txtBox_ErstePersonPluralImperfektKonjunktiv.Text = String.Empty;
            this.txtBox_ZweitePersonSingularImperfektKonjunktiv.Text = String.Empty;
            this.txtBox_ZweitePersonPluralImperfektKonjunktiv.Text = String.Empty;
            this.txtBox_DrittePersonSingularImperfektKonjunktiv.Text = String.Empty;
            this.txtBox_DrittePersonPluralImperfektKonjunktiv.Text = String.Empty;

            //Plusquamperfekt
            this.txtBox_ErstePersonSingularPlusquamperfektKonjunktiv.Text = String.Empty;
            this.txtBox_ErstePersonPluralPlusquamperfektKonjunktiv.Text = String.Empty;
            this.txtBox_ZweitePersonSingularPlusquamperfektKonjunktiv.Text = String.Empty;
            this.txtBox_ZweitePersonPluralPlusquamperfektKonjunktiv.Text = String.Empty;
            this.txtBox_DrittePersonSingularPlusquamperfektKonjunktiv.Text = String.Empty;
            this.txtBox_DrittePersonPluralPlusquamperfektKonjunktiv.Text = String.Empty;
        }

        private void Btn_LueckenFuellen_Click(object sender, EventArgs e)
        {
            this.txtBox_ZuDeutsch.Text = this.ausgewaehltesVerb.ZuDeutsch;

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
            this.txtBox_ErstePersonSingularFutur_IIndikativ.Text = this.ausgewaehltesVerb.ErstePersonSingularFutur_I_Indikativ;
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

        public void FillVerbenListeWithDefaults()
        {
            this.VerbenListe.Add(new Verb("properare", "eilen, sich beeilen"));
            this.VerbenListe[0].SetPraesensIndikativ("propero", "peroperas", "properat", "properamus", "properatis", "properant");
            this.VerbenListe[0].SetPerfektIndikativ("properavi", "properavisti", "properavit", "properavimus", "properavisti", "properaverunt");
            this.VerbenListe[0].SetImperfektIndikativ("properabam", "properabas", "properabat", "properabamus", "properabatis", "properabant");
            this.VerbenListe[0].SetPlusquamperfektIndikativ("properaveram", "properaveras", "properaverat", "properaveramus", "properaveratis", "properaverant");
            this.VerbenListe[0].SetFutur_I_Indikativ("properabo", "proberabis", "properabit", "properabimus", "properabitis", "properabunt");
            this.VerbenListe[0].SetFutur_II_Indikativ("properavero", "properaveris", "properaverit", "properavimus", "properabitis", "properaverint");
            this.VerbenListe[0].SetPraesensKonjunktiv("properem", "properes", "properet", "properemus", "properetis", "properent");
            this.VerbenListe[0].SetPerfektKonjunktiv("properaverim", "properaveris", "properaveret", "properemus", "properetis", "properent");
            this.VerbenListe[0].SetImperfektKonjunktiv("properarem", "properares", "properaret", "properaremus", "properaretis", "properarent");
            this.VerbenListe[0].SetPlusquamperfektKonjunktiv("properavissem", "properavisses", "properavisset", "properavissemus", "properavissetis", "properavissent");
        }

        private void SaveVerbenListeAsTextFile()
        {
            if(!Directory.Exists(@"C:\ProgramData\learnLatin"))
                Directory.CreateDirectory(@"C:\ProgramData\learnLatin");


            var stream = new FileStream(@"C:\ProgramData\learnLatin\Verben.txt", FileMode.OpenOrCreate, FileAccess.Write);
            var writer = new StreamWriter(stream);

            foreach(Verb verb in this.VerbenListe)
            {
                var line = String.Empty;

                var indikativ = verb.Infinitiv + "|" + verb.ErstePersonSingularPraesensIndikativ + ";" + verb.ErstePersonPluralPraesensIndikativ + ";" +
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

                var konjunktiv = verb.ErstePersonSingularPraesensKonjunktiv + ";" + verb.ErstePersonPluralPraesensKonjunktiv + ";" +
                    verb.ZweitePersonSingularPraesensKonjunktiv + ";" + verb.ZweitePersonPluralPraesensKonjunktiv + ";" + verb.DrittePersonSingularPraesensKonjunktiv + ";" +
                    verb.DrittePersonPluralPraesensKonjunktiv + "#" + verb.ErstePersonSingularPerfektKonjunktiv + ";" + verb.ErstePersonPluralPerfektKonjunktiv + ";" +
                    verb.ZweitePersonSingularPerfektKonjunktiv + ";" + verb.ZweitePersonPluralPerfektKonjunktiv + ";" + verb.DrittePersonSingularPerfektKonjunktiv + ";" +
                    verb.DrittePersonPluralPerfektKonjunktiv + "#" + verb.ErstePersonSingularImperfektKonjunktiv + ";" + verb.ErstePersonPluralImperfektKonjunktiv + ";" +
                    verb.ZweitePersonSingularImperfektKonjunktiv + ";" + verb.ZweitePersonPluralImperfektKonjunktiv + ";" + verb.DrittePersonSingularImperfektKonjunktiv + ";" +
                    verb.DrittePersonPluralImperfektKonjunktiv + "#" + verb.ErstePersonSingularPlusquamperfektKonjunktiv + ";" + verb.ErstePersonPluralPlusquamperfektKonjunktiv + ";" +
                    verb.ZweitePersonSingularPlusquamperfektKonjunktiv + ";" + verb.ZweitePersonPluralPlusquamperfektKonjunktiv + ";" + verb.DrittePersonSingularPlusquamperfektKonjunktiv + ";" +
                    verb.DrittePersonPluralPlusquamperfektKonjunktiv;

                line = indikativ + konjunktiv + "|" + verb.ZuDeutsch;

                writer.WriteLine(line);
            }

            writer.Close();
            stream.Close();
        }

        private void FillVerbenListeFromTextFile()
        {
            if(!Directory.Exists(@"C:\ProgramData\learnLatin"))
                Directory.CreateDirectory(@"C:\ProgramData\learnLatin");

            if(!File.Exists(@"C:\ProgramData\learnLatin\Verben.txt"))
                return;

            this.VerbenListe.Clear();

            var stream = new FileStream(@"C:\ProgramData\learnLatin\Verben.txt", FileMode.Open, FileAccess.Read);
            var reader = new StreamReader(stream);

            string line;
            Verb verb;



            while((line = reader.ReadLine()) != null)
            {
                var infinitiv = line.Split('|')[0];
                var zuDeutsch = line.Split('|')[3];
                var indikativString = line.Split('|')[1];
                var konjunktivString = line.Split('|')[2];

                verb = new Verb(infinitiv, zuDeutsch);

                var praesens = indikativString.Split('#')[0];
                var perfekt = indikativString.Split('#')[1];
                var imperfekt = indikativString.Split('#')[2];
                var plusquamperfekt = indikativString.Split('#')[3];
                var futur_I = indikativString.Split('#')[4];
                var futur_II = indikativString.Split('#')[5];
                    
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

        private void Verbs_Load(object sender, EventArgs e)
        {
            this.FillVerbenListeFromTextFile();

            if(this.VerbenListe.Count== 0)
                FillVerbenListeWithDefaults();

            this.btn_NaechstesVerb.PerformClick();
        }

        private void Verbs_FormClosing(object sender, FormClosingEventArgs e) => this.SaveVerbenListeAsTextFile();

        private void Btn_VerbHinzufuegen_Click(object sender, EventArgs e)
        {
            var verb = new Verb(this.txtBox_Infinitiv.Text, this.txtBox_ZuDeutsch.Text);

            //Indikativ
            verb.SetPraesensIndikativ(this.txtBox_ErstePersonSingularPraesensIndikativ.Text, this.txtBox_ErstePersonPluralPraesensIndikativ.Text,
                this.txtBox_ZweitePersonSingularPraesensIndikativ.Text, this.txtBox_ZweitePersonPluralPraesensIndikativ.Text,
                this.txtBox_DrittePersonSingularPraesensIndikativ.Text, this.txtBox_DrittePersonPluralPraesensIndikativ.Text);

            verb.SetPerfektIndikativ(this.txtBox_ErstePersonSingularPerfektIndikativ.Text, this.txtBox_ErstePersonPluralPerfektIndikativ.Text,
                this.txtBox_ZweitePersonSingularPerfektIndikativ.Text, this.txtBox_ZweitePersonPluralPerfektIndikativ.Text,
                this.txtBox_DrittePersonSingularPerfektIndikativ.Text, this.txtBox_DrittePersonPluralPerfektIndikativ.Text);

            verb.SetImperfektIndikativ(this.txtBox_ErstePersonSingularImperfektIndikativ.Text, this.txtBox_ErstePersonPluralImperfektIndikativ.Text,
                this.txtBox_ZweitePersonSingularImperfektIndikativ.Text, this.txtBox_ZweitePersonPluralImperfektIndikativ.Text,
                this.txtBox_DrittePersonSingularImperfektIndikativ.Text, this.txtBox_DrittePersonPluralImperfektIndikativ.Text);

            verb.SetPlusquamperfektIndikativ(this.txtBox_ErstePersonSingularPlusquamperfektIndikativ.Text, this.txtBox_ErstePersonPluralPlusquamperfektIndikativ.Text,
                this.txtBox_ZweitePersonSingularPlusquamperfektIndikativ.Text, this.txtBox_ZweitePersonPluralPlusquamperfektIndikativ.Text,
                this.txtBox_DrittePersonSingularPlusquamperfektIndikativ.Text, this.txtBox_DrittePersonPluralPlusquamperfektIndikativ.Text);

            verb.SetFutur_I_Indikativ(this.txtBox_ErstePersonSingularFutur_IIndikativ.Text, this.txtBox_ErstePersonPluralFutur_IIndikativ.Text,
                this.txtBox_ZweitePersonSingularFutur_IIndikativ.Text, this.txtBox_ZweitePersonPluralFutur_IIndikativ.Text,
                this.txtBox_DrittePersonSingularFutur_IIndikativ.Text, this.txtBox_DrittePersonPluralFutur_IIndikativ.Text);

            verb.SetFutur_II_Indikativ(this.txtBox_ErstePersonPluralFutur_IIIndikativ.Text, this.txtBox_ErstePersonPluralFutur_IIIndikativ.Text,
                this.txtBox_ZweitePersonSingularFutur_IIIndikativ.Text, this.txtBox_ZweitePersonPluralFutur_IIIndikativ.Text,
                this.txtBox_DrittePersonSingularFutur_IIIndikativ.Text, this.txtBox_DrittePersonPluralFutur_IIIndikativ.Text);


            //Konjunktiv
            verb.SetPraesensKonjunktiv(this.txtBox_ErstePersonSingularPraesensKonjunktiv.Text, this.txtBox_ErstePersonPluralPraesensKonjunktiv.Text,
            this.txtBox_ZweitePersonSingularPraesensKonjunktiv.Text, this.txtBox_ZweitePersonPluralPraesensKonjunktiv.Text,
            this.txtBox_DrittePersonSingularPraesensKonjunktiv.Text, this.txtBox_DrittePersonPluralPraesensKonjunktiv.Text);

            verb.SetPerfektKonjunktiv(this.txtBox_ErstePersonSingularPerfektKonjunktiv.Text, this.txtBox_ErstePersonPluralPerfektKonjunktiv.Text,
                this.txtBox_ZweitePersonSingularPerfektKonjunktiv.Text, this.txtBox_ZweitePersonPluralPerfektKonjunktiv.Text,
                this.txtBox_DrittePersonSingularPerfektKonjunktiv.Text, this.txtBox_DrittePersonPluralPerfektKonjunktiv.Text);

            verb.SetImperfektKonjunktiv(this.txtBox_ErstePersonSingularImperfektKonjunktiv.Text, this.txtBox_ErstePersonPluralImperfektKonjunktiv.Text,
                this.txtBox_ZweitePersonSingularImperfektKonjunktiv.Text, this.txtBox_ZweitePersonPluralImperfektKonjunktiv.Text,
                this.txtBox_DrittePersonSingularImperfektKonjunktiv.Text, this.txtBox_DrittePersonPluralImperfektKonjunktiv.Text);

            verb.SetPlusquamperfektKonjunktiv(this.txtBox_ErstePersonSingularPlusquamperfektKonjunktiv.Text, this.txtBox_ErstePersonPluralPlusquamperfektKonjunktiv.Text,
                this.txtBox_ZweitePersonSingularPlusquamperfektKonjunktiv.Text, this.txtBox_ZweitePersonPluralPlusquamperfektKonjunktiv.Text,
                this.txtBox_DrittePersonSingularPlusquamperfektKonjunktiv.Text, this.txtBox_DrittePersonPluralPlusquamperfektKonjunktiv.Text);



            this.VerbenListe.Add(verb);
            verb = null;

            this.SaveVerbenListeAsTextFile();

            MessageBox.Show("Das Verb wurde erfolgreich hinzugefügt!");

            this.btn_NaechstesVerb.PerformClick();
        }
    }












    public class Verb
    {
        public string Infinitiv;
        public string ZuDeutsch;

        //Indikativ
        //Praesens
        public string ErstePersonSingularPraesensIndikativ;
        public string ErstePersonPluralPraesensIndikativ;
        public string ZweitePersonSingularPraesensIndikativ;
        public string ZweitePersonPluralPraesensIndikativ;
        public string DrittePersonSingularPraesensIndikativ;
        public string DrittePersonPluralPraesensIndikativ;

        //Perfekt
        public string ErstePersonSingularPerfektIndikativ;
        public string ErstePersonPluralPerfektIndikativ;
        public string ZweitePersonSingularPerfektIndikativ;
        public string ZweitePersonPluralPerfektIndikativ;
        public string DrittePersonSingularPerfektIndikativ;
        public string DrittePersonPluralPerfektIndikativ;

        //Imperfekt
        public string ErstePersonSingularImperfektIndikativ;
        public string ErstePersonPluralImperfektIndikativ;
        public string ZweitePersonSingularImperfektIndikativ;
        public string ZweitePersonPluralImperfektIndikativ;
        public string DrittePersonSingularImperfektIndikativ;
        public string DrittePersonPluralImperfektIndikativ;

        //Plusquamperfekt
        public string ErstePersonSingularPlusquamperfektIndikativ;
        public string ErstePersonPluralPlusquamperfektIndikativ;
        public string ZweitePersonSingularPlusquamperfektIndikativ;
        public string ZweitePersonPluralPlusquamperfektIndikativ;
        public string DrittePersonSingularPlusquamperfektIndikativ;
        public string DrittePersonPluralPlusquamperfektIndikativ;

        //Futur I
        public string ErstePersonSingularFutur_I_Indikativ;
        public string ErstePersonPluralFutur_I_Indikativ;
        public string ZweitePersonSingularFutur_I_Indikativ;
        public string ZweitePersonPluralFutur_I_Indikativ;
        public string DrittePersonSingularFutur_I_Indikativ;
        public string DrittePersonPluralFutur_I_Indikativ;

        //Futur II
        public string ErstePersonSingularFutur_II_Indikativ;
        public string ErstePersonPluralFutur_II_Indikativ;
        public string ZweitePersonSingularFutur_II_Indikativ;
        public string ZweitePersonPluralFutur_II_Indikativ;
        public string DrittePersonSingularFutur_II_Indikativ;
        public string DrittePersonPluralFutur_II_Indikativ;


        //Konjunktiv
        //Praesens
        public string ErstePersonSingularPraesensKonjunktiv;
        public string ErstePersonPluralPraesensKonjunktiv;
        public string ZweitePersonSingularPraesensKonjunktiv;
        public string ZweitePersonPluralPraesensKonjunktiv;
        public string DrittePersonSingularPraesensKonjunktiv;
        public string DrittePersonPluralPraesensKonjunktiv;

        //Perfekt
        public string ErstePersonSingularPerfektKonjunktiv;
        public string ErstePersonPluralPerfektKonjunktiv;
        public string ZweitePersonSingularPerfektKonjunktiv;
        public string ZweitePersonPluralPerfektKonjunktiv;
        public string DrittePersonSingularPerfektKonjunktiv;
        public string DrittePersonPluralPerfektKonjunktiv;

        //Imperfekt
        public string ErstePersonSingularImperfektKonjunktiv;
        public string ErstePersonPluralImperfektKonjunktiv;
        public string ZweitePersonSingularImperfektKonjunktiv;
        public string ZweitePersonPluralImperfektKonjunktiv;
        public string DrittePersonSingularImperfektKonjunktiv;
        public string DrittePersonPluralImperfektKonjunktiv;

        //Plusquamperfekt
        public string ErstePersonSingularPlusquamperfektKonjunktiv;
        public string ErstePersonPluralPlusquamperfektKonjunktiv;
        public string ZweitePersonSingularPlusquamperfektKonjunktiv;
        public string ZweitePersonPluralPlusquamperfektKonjunktiv;
        public string DrittePersonSingularPlusquamperfektKonjunktiv;
        public string DrittePersonPluralPlusquamperfektKonjunktiv; 

        public void SetPraesensIndikativ(string ErstePersonSingular, string ErstePersonPlural, string ZweitePersonSingular, string ZweitePersonPlural,
            string DrittePersonSingular, string DrittePersonPlural)
        {
            this.ErstePersonSingularPraesensIndikativ = ErstePersonSingular;
            this.ErstePersonPluralPraesensIndikativ = ErstePersonPlural;
            this.ZweitePersonSingularPraesensIndikativ = ZweitePersonSingular;
            this.ZweitePersonPluralPraesensIndikativ = ZweitePersonPlural;
            this.DrittePersonSingularPraesensIndikativ = DrittePersonSingular;
            this.DrittePersonPluralPraesensIndikativ = DrittePersonPlural;
        }

        public void SetPerfektIndikativ(string ErstePersonSingular, string ErstePersonPlural, string ZweitePersonSingular, string ZweitePersonPlural,
            string DrittePersonSingular, string DrittePersonPlural)
        {
            this.ErstePersonSingularPerfektIndikativ = ErstePersonSingular;
            this.ErstePersonPluralPerfektIndikativ = ErstePersonPlural;
            this.ZweitePersonSingularPerfektIndikativ = ZweitePersonSingular;
            this.ZweitePersonPluralPerfektIndikativ = ZweitePersonPlural;
            this.DrittePersonSingularPerfektIndikativ = DrittePersonSingular;
            this.DrittePersonPluralPerfektIndikativ = DrittePersonPlural;
        }

        public void SetImperfektIndikativ(string ErstePersonSingular, string ErstePersonPlural, string ZweitePersonSingular, string ZweitePersonPlural,
            string DrittePersonSingular, string DrittePersonPlural)
        {
            this.ErstePersonSingularImperfektIndikativ = ErstePersonSingular;
            this.ErstePersonPluralImperfektIndikativ = ErstePersonPlural;
            this.ZweitePersonSingularImperfektIndikativ = ZweitePersonSingular;
            this.ZweitePersonPluralImperfektIndikativ = ZweitePersonPlural;
            this.DrittePersonSingularImperfektIndikativ = DrittePersonSingular;
            this.DrittePersonPluralImperfektIndikativ = DrittePersonPlural;
        }

        public void SetPlusquamperfektIndikativ(string ErstePersonSingular, string ErstePersonPlural, string ZweitePersonSingular, string ZweitePersonPlural,
            string DrittePersonSingular, string DrittePersonPlural)
        {
            this.ErstePersonSingularPlusquamperfektIndikativ = ErstePersonSingular;
            this.ErstePersonPluralPlusquamperfektIndikativ = ErstePersonPlural;
            this.ZweitePersonSingularPlusquamperfektIndikativ = ZweitePersonSingular;
            this.ZweitePersonPluralPlusquamperfektIndikativ = ZweitePersonPlural;
            this.DrittePersonSingularPlusquamperfektIndikativ = DrittePersonSingular;
            this.DrittePersonPluralPlusquamperfektIndikativ = DrittePersonPlural;
        }

        public void SetFutur_I_Indikativ(string ErstePersonSingular, string ErstePersonPlural, string ZweitePersonSingular, string ZweitePersonPlural,
            string DrittePersonSingular, string DrittePersonPlural)
        {
            this.ErstePersonSingularFutur_I_Indikativ = ErstePersonSingular;
            this.ErstePersonPluralFutur_I_Indikativ = ErstePersonPlural;
            this.ZweitePersonSingularFutur_I_Indikativ = ZweitePersonSingular;
            this.ZweitePersonPluralFutur_I_Indikativ = ZweitePersonPlural;
            this.DrittePersonSingularFutur_I_Indikativ = DrittePersonSingular;
            this.DrittePersonPluralFutur_I_Indikativ = DrittePersonPlural;
        }

        public void SetFutur_II_Indikativ(string ErstePersonSingular, string ErstePersonPlural, string ZweitePersonSingular, string ZweitePersonPlural,
            string DrittePersonSingular, string DrittePersonPlural)
        {
            this.ErstePersonSingularFutur_II_Indikativ = ErstePersonSingular;
            this.ErstePersonPluralFutur_II_Indikativ = ErstePersonPlural;
            this.ZweitePersonSingularFutur_II_Indikativ = ZweitePersonSingular;
            this.ZweitePersonPluralFutur_II_Indikativ = ZweitePersonPlural;
            this.DrittePersonSingularFutur_II_Indikativ = DrittePersonSingular;
            this.DrittePersonPluralFutur_II_Indikativ = DrittePersonPlural;
        }

        public void SetPraesensKonjunktiv(string ErstePersonSingular, string ErstePersonPlural, string ZweitePersonSingular, string ZweitePersonPlural,
            string DrittePersonSingular, string DrittePersonPlural)
        {
            this.ErstePersonSingularPraesensKonjunktiv = ErstePersonSingular;
            this.ErstePersonPluralPraesensKonjunktiv = ErstePersonPlural;
            this.ZweitePersonSingularPraesensKonjunktiv = ZweitePersonSingular;
            this.ZweitePersonPluralPraesensKonjunktiv = ZweitePersonPlural;
            this.DrittePersonSingularPraesensKonjunktiv = DrittePersonSingular;
            this.DrittePersonPluralPraesensKonjunktiv = DrittePersonPlural;
        }

        public void SetPerfektKonjunktiv(string ErstePersonSingular, string ErstePersonPlural, string ZweitePersonSingular, string ZweitePersonPlural,
            string DrittePersonSingular, string DrittePersonPlural)
        {
            this.ErstePersonSingularPerfektKonjunktiv = ErstePersonSingular;
            this.ErstePersonPluralPerfektKonjunktiv = ErstePersonPlural;
            this.ZweitePersonSingularPerfektKonjunktiv = ZweitePersonSingular;
            this.ZweitePersonPluralPerfektKonjunktiv = ZweitePersonPlural;
            this.DrittePersonSingularPerfektKonjunktiv = DrittePersonSingular;
            this.DrittePersonPluralPerfektKonjunktiv = DrittePersonPlural;
        }

        public void SetImperfektKonjunktiv(string ErstePersonSingular, string ErstePersonPlural, string ZweitePersonSingular, string ZweitePersonPlural,
            string DrittePersonSingular, string DrittePersonPlural)
        {
            this.ErstePersonSingularImperfektKonjunktiv = ErstePersonSingular;
            this.ErstePersonPluralImperfektKonjunktiv = ErstePersonPlural;
            this.ZweitePersonSingularImperfektKonjunktiv = ZweitePersonSingular;
            this.ZweitePersonPluralImperfektKonjunktiv = ZweitePersonPlural;
            this.DrittePersonSingularImperfektKonjunktiv = DrittePersonSingular;
            this.DrittePersonPluralImperfektKonjunktiv = DrittePersonPlural;
        }

        public void SetPlusquamperfektKonjunktiv(string ErstePersonSingular, string ErstePersonPlural, string ZweitePersonSingular, string ZweitePersonPlural,
            string DrittePersonSingular, string DrittePersonPlural)
        {
            this.ErstePersonSingularPlusquamperfektKonjunktiv = ErstePersonSingular;
            this.ErstePersonPluralPlusquamperfektKonjunktiv = ErstePersonPlural;
            this.ZweitePersonSingularPlusquamperfektKonjunktiv = ZweitePersonSingular;
            this.ZweitePersonPluralPlusquamperfektKonjunktiv = ZweitePersonPlural;
            this.DrittePersonSingularPlusquamperfektKonjunktiv = DrittePersonSingular;
            this.DrittePersonPluralPlusquamperfektKonjunktiv = DrittePersonPlural;
        }


        public Verb(string Infinitiv, string ZuDeutsch)
        {
            this.Infinitiv = Infinitiv;
            this.ZuDeutsch = ZuDeutsch;
        }
    }
}
