using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening2
{
    public partial class formGemiddelde : Form
    {
        public formGemiddelde()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNieuwGetal_Click(object sender, EventArgs e)
        {
            /*Ik maak een nieuwe formDialogue aan.
             Deze noem ik 'dialoguescherm' en deze toon ik vervolgens
            a.d.h.v. de ShowDialog() methode.*/
            formDialogue dialoguescherm = new formDialogue();
            dialoguescherm.ShowDialog();

            /*Wanneer DialogResult 'OK is',
             laat ik de nodige methoden uitvoeren.
            Deze methoden voegen het getal van dialoguescherm toe aan de lijst,
            berekenen het gemiddelde en sluit het dialoguescherm.
            DialogResult wordt op 'OK' gezet wanneer er op de OK-button wordt geklikt.
            DialogResult zet ik op OK via de design in de properties en niet via de code.*/
            if (dialoguescherm.DialogResult == DialogResult.OK)
            {
                Toevoegen(dialoguescherm.getal);
                berekenGemiddelde();
                dialoguescherm.Dispose();
            }
        }

        /*Deze methode voegt een getal toe aan de getallenlijst.*/
        public void Toevoegen(double getal)
        {
            lbxGetallenlijst.Items.Add(getal);

        }

        /*Deze methode loopt doorhen de listbox 'lbxGetallenlijst.'
         Deze berekent vervolgens het gemiddelde.
        In het tekstveldje 'tbNieuwGetal' wordt het nieuwe gemiddelde gezet.
        tbNieuwGetal is een ReadOnly tekstveld,
        wat inhoudt dat je er zelf geen waarde in kan zetten.
        Je kan hier de waarde alleen in aflezen.*/
        public void berekenGemiddelde()
        {

            double totaal = 0;


            for (int i = 0; i < lbxGetallenlijst.Items.Count; i++)
            {
                totaal = totaal + double.Parse(lbxGetallenlijst.Items[i].ToString());
            }

            totaal = (totaal / lbxGetallenlijst.Items.Count);


            tbNieuwGetal.Text = totaal.ToString();

        }
    }
}
