namespace Oefening1
{
    public partial class formMenu : Form
    {
        public formMenu()
        {
            InitializeComponent();
        }
        

        private void mstitemRed_Click(object sender, EventArgs e)
        {
            /*Ik pas de tekstkleur van de tekst in het tekstveld aan naar rood.*/
            tbSerpentTooth.ForeColor = Color.Red;
        }

        private void mstitemGreen_Click(object sender, EventArgs e)
        {
            /*Ik pas de tekstkleur van de tekst in het tekstveld aan naar groen.*/
            tbSerpentTooth.ForeColor = Color.Green;
        }

        private void mstitemBlue_Click(object sender, EventArgs e)
        {
            /*Ik pas de tekstkleur van de tekst in het tekstveld aan naar blauw.*/
            tbSerpentTooth.ForeColor = Color.Blue;
        }

        private void mstitemBGRed_Click(object sender, EventArgs e)
        {
            /*Ik pas de achtergrondkleur van het tekstveld aan naar rood.*/
            tbSerpentTooth.BackColor = Color.Red;
        }

        private void mstitemBGGreen_Click(object sender, EventArgs e)
        {
            /*Ik pas de achtergrondkleur van het tekstveld aan naar groen.*/
            tbSerpentTooth.BackColor = Color.Green;
        }

        private void mstitemBGBlue_Click(object sender, EventArgs e)
        {
            /*Ik pas de achtergrondkleur van het tekstveld aan naar blauw.*/
            tbSerpentTooth.BackColor = Color.Blue;
        }

        private void mstitemSmall_Click(object sender, EventArgs e)
        {
            /*Ik pas de font-size van het tekstveld aan naar 5.
             Klaarblijkelijk ben ik verplicht om hierbij ook telkens de font zelf te bepalen.*/
            tbSerpentTooth.Font = new Font("Segou UI", 5);
        }

        private void mstitemNormal_Click(object sender, EventArgs e)
        {
            /*Ik pas de font-size van het tekstveld aan naar 8.
             Klaarblijkelijk ben ik verplicht om hierbij ook telkens de font zelf te bepalen.*/
            tbSerpentTooth.Font = new Font("Segou UI", 8);
        }

        private void mstitemLarge_Click(object sender, EventArgs e)
        {
            /*Ik pas de font-size van het tekstveld aan naar 12.
             Klaarblijkelijk ben ik verplicht om hierbij ook telkens de font zelf te bepalen.*/
            tbSerpentTooth.Font = new Font("Segou UI", 12);
        }

        private void mstitemExit_Click(object sender, EventArgs e)
        {
            /*Ik sluit de form. met the Close() methode.*/
            this.Close();
        }

        private void mstitemFont_Click(object sender, EventArgs e)
        {
            /*Ik zorg ervoor dat de tekst van de menu-strip-items die een font-size symboliseren,
             ook de font-size zelf met zich dragen.
            Dat maakt het visueel fijner.*/
            mstitemSmall.Font = new Font("Segou UI", 5);
            mstitemNormal.Font = new Font("Segou UI", 8);
            mstitemLarge.Font = new Font("Segou UI", 12);
        }
    }
}