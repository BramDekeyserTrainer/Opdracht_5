using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Oefening2
{
    public partial class formDialogue : Form
    {
        /*Ik maak de formGemiddelde aan met de naam 'Childform'.*/
        formGemiddelde childform = new formGemiddelde();

        /*Ik declareer de double 'getal'.
         Ik get en set deze.
        Dit doe ik niet meer op de Javaiaanse wijzen,
        zoals u had gevraagd.*/
        public double getal { get; set; }
        public formDialogue()
        {
            InitializeComponent();
        }

        private void formDialogue_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            /*Ik stel this.getal gelijk aan de geparste waarde van de tekstinhoud van het tekstveld
             tbGeefGetal. 
             Deze wordt naar een double geparsd.*/
            this.getal = double.Parse(tbGeefGetal.Text);
            
        }
    }
}
