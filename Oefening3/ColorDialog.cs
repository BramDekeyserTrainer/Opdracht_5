using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Oefening3
{
    public partial class ColorDialog : Form
    {
        public ColorDialog()
        {
            InitializeComponent();
        }

        private void ColorDialog_Load(object sender, EventArgs e)
        {
            nupdwnRood.Value = formRechthoeken.Rood[formRechthoeken.Huidig];
            nupdwnGroen.Value = formRechthoeken.Groen[formRechthoeken.Huidig];
            nupdwnBlauw.Value = formRechthoeken.Blauw[formRechthoeken.Huidig];
            nupdwnAlpha.Value = formRechthoeken.Alpha[formRechthoeken.Huidig];
        }
        private void nupdwnRood_ValueChanged(object sender, EventArgs e)
        {
            formRechthoeken.Rood[formRechthoeken.Huidig] = (int)nupdwnRood.Value;
            formRechthoeken.HuidigVeld.BackColor =  Color.FromArgb(
                formRechthoeken.Alpha[formRechthoeken.Huidig], 
                formRechthoeken.Rood[formRechthoeken.Huidig], 
                formRechthoeken.Groen[formRechthoeken.Huidig], 
                formRechthoeken.Blauw[formRechthoeken.Huidig]
                );
        }
        private void nupdwnGroen_ValueChanged(object sender, EventArgs e)
        {
            formRechthoeken.Groen[formRechthoeken.Huidig] = (int)nupdwnRood.Value;
            formRechthoeken.HuidigVeld.BackColor = Color.FromArgb(
                formRechthoeken.Alpha[formRechthoeken.Huidig],
                formRechthoeken.Rood[formRechthoeken.Huidig],
                formRechthoeken.Groen[formRechthoeken.Huidig],
                formRechthoeken.Blauw[formRechthoeken.Huidig]
                );
        }

        private void nupdwnBlauw_ValueChanged(object sender, EventArgs e)
        {
            formRechthoeken.Blauw[formRechthoeken.Huidig] = (int)nupdwnRood.Value;
            formRechthoeken.HuidigVeld.BackColor = Color.FromArgb(
                formRechthoeken.Alpha[formRechthoeken.Huidig],
                formRechthoeken.Rood[formRechthoeken.Huidig],
                formRechthoeken.Groen[formRechthoeken.Huidig],
                formRechthoeken.Blauw[formRechthoeken.Huidig]
                );
        }

        private void nupdwnAlpha_ValueChanged(object sender, EventArgs e)
        {
            formRechthoeken.Alpha[formRechthoeken.Huidig] = (int)nupdwnRood.Value;
            formRechthoeken.HuidigVeld.BackColor = Color.FromArgb(
                formRechthoeken.Alpha[formRechthoeken.Huidig],
                formRechthoeken.Rood[formRechthoeken.Huidig],
                formRechthoeken.Groen[formRechthoeken.Huidig],
                formRechthoeken.Blauw[formRechthoeken.Huidig]
                );
        }
    }
}
