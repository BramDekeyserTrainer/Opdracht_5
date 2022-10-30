using System.Windows.Forms;

namespace Oefening3
{
    public partial class formRechthoeken : Form
    {


        public formRechthoeken()
        {
            InitializeComponent();
        }
        /*Ik maak de variabelen aan.*/
        private int x = 0;

        /*De y-positie wordt op 49 gezet aangezien de knoppen 48 hoog zijn.*/
        private int y = 49;

        private int breedte = 0;

        private int hoogte = 0;

        public static int teller;

        /*De onderstaande variabelen dienen ervoor het aantal rijen en kolommen te kunnen berekenen*/

        public static int telRijen;

        public static int telKolommen;

        /*Ik maak vier lijsten aan, die elk één van de RGBA kleuren voorstelt.
         Eerst maak ik Rood, Groen en blauw aan.
        Vervolgens maak ik ook een Alpha waarde aan.
        De alpha waarde gaat over de transparantie van een kleur.
        Elke tint kan een waarde van 0 tot en met 255 bevatten.
        Dit zijn dus lists met integers.*/
        public static List<int> Rood = new List<int>();
        public static List<int> Groen = new List<int>();
        public static List<int> Blauw = new List<int>();
        public static List<int> Alpha = new List<int>();

        /*Ik maak ook nog een lijst aan met tekstvelden.
         Het zijn als het ware die tekstvelden die de rechthoeken gaan voorstellen.*/
        public static List<TextBox> tekstvelden = new List<TextBox>();

        /*Een nieuw tekstveld wordt aangemaakt.*/
        public static TextBox HuidigVeld = new TextBox();

        /*Ik maak een static integer 'Huidig' aan.*/
        public static int Huidig;

        /*Ik declareer een nieuwe ColorDialog met de naam 'rgba'.*/
        private ColorDialog rgba;

        public void MetenIsWeten()
        {
            int berekenaar = 1;

            /*Als teller gelijk is aan 1,
             Wordt de variabele 'berekenaar' hier ook aan gelijk gesteld.*/
            if (teller == 1)
            {
                berekenaar = 1;

            }
            /*Als de teller groter of gelijk is aan 2,
             gebruik ik Math.Ceiling op de teller om de kleinste integrale waarde te  vinden.
            Math.Sqrt gebruik ik voor de vierkantswortel.*/
            else if (teller >= 2)
            {
                berekenaar = (int)Math.Ceiling(Math.Sqrt(teller));
            }

            /*Ik bepaal de breedte en de hoogte*/
            breedte = (this.Size.Width - 19) / berekenaar;
            hoogte = (this.Size.Height - 76) / berekenaar;

            /*Bij de volgende conditie, beepaal ik de positie van de rechthoek.*/
            if (telKolommen < berekenaar)
            {
                x = (this.Size.Width - 19) * telRijen / berekenaar;
                y = (this.Size.Height - 76) * telKolommen / berekenaar + 49;
            }

            /*telKolommen wordt geincriment met 1.*/
            telKolommen++;

            if (telKolommen == berekenaar)
            {
                telRijen++;
                telKolommen = 0;
            }
        }

        private void formRechthoeken_Load(object sender, EventArgs e)
        {
            
    }

        /*Bij de onderstaande knopt dient er na het klikken op de knop,
         een rechthoek gemaakt te worden.*/
        private void btnVoegRechthoekToe_Click(object sender, EventArgs e)
        {
            /*De variabele reedsGeteld wordt gelijkgesteld aan teller.*/
            int reedsGeteld = teller;
            
            /*Ik verklaar dat de control moet worde verwijderd op de positie van reedsGeteld.*/
            for (int i = 0; i < teller; i++)
            {
                this.Controls.RemoveAt(reedsGeteld);

                /*Ik decrement reedsGeteld met 1.*/
                reedsGeteld--;
            }

            /*Ik increment teller met 1.*/
            teller++;

            telKolommen = 0;
            telRijen = 0;

            /*In deze for-loop voeg ik de kleuren toe.
             Ik gebruik als basis RGBa(100,0,0,255).
            Aangezien ik de foutmelding kreeg dat een control niet transparant mocht zijn, 
            heb ik de Alpha waarde op haar volledige 255 gezet.*/
            for (int i = 0; i < teller; i++)
            {
                Rood.Add(100);
                Groen.Add(0);
                Blauw.Add(0);
                Alpha.Add(255);

                /*Ik roep de methode MetenIsWeten op.*/
                MetenIsWeten();

                /*Ik maak een nieuwe rechthoek aan.
                 Deze is een textbox*/
                TextBox Rechthoek = new TextBox();

                /*Ik voeg de eigenschappen van de rechthoek toe.*/
                Rechthoek.Multiline = true;
                Rechthoek.Location = new Point(x, y);
                Rechthoek.Size = new Size(breedte, hoogte);
                Rechthoek.BackColor = Color.FromArgb(Alpha[i], Rood[i], Groen[i], Blauw[i]);
                Rechthoek.MouseHover += new EventHandler(TextBox_MouseHover);
                this.Controls.Add(Rechthoek);
                tekstvelden.Add(Rechthoek);
            }
        }

        private void FormRechthoeken_SizeChanged(object sender, EventArgs e)
        {
            /*Ik declareer de variabele 'reedsGeteld' en stel deze gelijk aan teller.*/
            int reedsGeteld = teller;

            /*Ik verklaar dat de control moet worde verwijderd op de positie van reedsGeteld.*/
            for (int i = 0; i < teller; i++)
            {
                this.Controls.RemoveAt(reedsGeteld);
                
                /*Ik decrement reedsGeteeld met 1.*/
                reedsGeteld--;
            }

            telKolommen = 0;
            telRijen = 0;
            for (int i = 0; i < teller; i++)
            {
                /*Ik roep de methode MetenIsWeten op.*/
                MetenIsWeten();

                /*Ik maak een nieuwe rechthoek aan.
                 Deze is een textbox*/
                TextBox Rechthoek = new TextBox();

                /*Ik voeg de eigenschappen van de rechthoek toe.*/
                Rechthoek.Multiline = true;
                Rechthoek.Location = new Point(x, y);
                Rechthoek.Size = new Size(breedte, hoogte);
                Rechthoek.BackColor = Color.FromArgb(Alpha[i], Rood[i], Groen[i], Blauw[i]);
                Rechthoek.MouseHover += new EventHandler(TextBox_MouseHover);
                this.Controls.Add(Rechthoek);
                tekstvelden.Add(Rechthoek);
            }
        }

        public void TextBox_MouseHover(object sender, EventArgs e)
        {
            /*Als rgba niet null is, zal deze niet zichtbaar worden.*/
            if (rgba != null)
            {
                rgba.Visible = false;
            }

            HuidigVeld = (TextBox)sender;

            /*Ik declareer een nieuwe ColorDialog.
             Deze noem ik 'colorDialog.'*/
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Location = new Point(HuidigVeld.Location.X + this.Location.X, HuidigVeld.Location.Y + this.Location.Y);
            
            /*Ik maak colorDialog zichtbaar voor de gebruiker.*/
            colorDialog.Visible = true;

            /*rgba wordt gelijkgesteld aan colorDialog.*/
            rgba = colorDialog;

            /*Ik stel Huidig gelijk aan de index in de tekstvelden list op de positie HuidigVeld.*/
            Huidig = tekstvelden.IndexOf(HuidigVeld);

        }

        /*De onderstaande knop dient er toe de dienen een rechthoek te verwijderen.*/
        private void btnVerwijderRechthoek_Click(object sender, EventArgs e)
        {
            /*Ik declareer de integer 'aftrekker' die ik gelijks tel aan teller.*/
            int aftrekker = teller;

            /*Bij de voolgende conditie, verwijder ik binnen de controls op de positie 'aftrekker'.*/
            for (int i = 0; i < teller; i++)
            {
                this.Controls.RemoveAt(aftrekker);

                /*Ik decrement 'aftrekker' met 1.*/
                aftrekker--;
            }

            /*Ik decrement teller met 1.*/
            teller--;

            telKolommen = 0;
            telRijen = 0;

            for (int i = 0; i < teller; i++)
            {
                /*Ik roep de methode MetenIsWeten op.*/
                MetenIsWeten();

                /*Ik maak een nieuwe rechthoek aan.
                 Deze is een textbox*/
                TextBox Rechthoek = new TextBox();

                /*Ik voeg de eigenschappen van de rechthoek toe.*/
                Rechthoek.Multiline = true;
                Rechthoek.Location = new Point(x, y);
                Rechthoek.Size = new Size(breedte, hoogte);
                Rechthoek.BackColor = Color.FromArgb(Alpha[i], Rood[i], Groen[i], Blauw[i]);
                Rechthoek.MouseHover += new EventHandler(TextBox_MouseHover);
                this.Controls.Add(Rechthoek);
                tekstvelden.Add(Rechthoek);
            }
        }
    }
}