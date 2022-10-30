namespace Oefening2
{
    public partial class formGemiddeldeMDI : Form
    {
        /*Ik maak nieuwe formGemiddelde aan.
         Deze noem ik 'childform'.*/
        formGemiddelde childform = new formGemiddelde();
        public formGemiddeldeMDI()
        {
            InitializeComponent();
        }

        private void formGemiddeldeMDI_Load(object sender, EventArgs e)
        {
            /*Ik zeg dat deze form een MdiContainer is.*/
            this.IsMdiContainer = true;

            /*Ik verklaar dat de form 'Childform',
             deze form, zijnde GemiddeldeMDI, als MDI parent heeft.*/
            childform.MdiParent = this;

            /*Nadat ik heb verklaard dat de Childform een childform is van de MDI parent,
             laat ik ook de Childform zien.*/
            childform.Show();
        }
    }
}