namespace prySilvaContacto
{
    public partial class frmContacto : Form
    {
        public frmContacto()
        {
            InitializeComponent();
        }

        string contacto;
        string telefono;
        int cont = 1;

        string[] aContacto = new string[4];
        string[] aTelefono = new string[4];
        int i = 0;

        private void cmdGrabar_Click(object sender, EventArgs e)
        {
            //contacto = txtContacto.Text;
            //telefono = mskTelefono.Text;

            aContacto[i] = txtContacto.Text;
            aTelefono[i] = mskTelefono.Text;

            
            lstDatos.Items.Add(cont + ". " + aContacto[i] + " - " + aTelefono[i]);
            cont++;
            i++;

            txtContacto.Clear();
            mskTelefono.Clear();
            txtContacto.Focus();
        }

        private void frmContacto_Load(object sender, EventArgs e)
        {

        }
    }
}
