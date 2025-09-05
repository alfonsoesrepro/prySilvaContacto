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
        int cont = 0;

        private void cmdGrabar_Click(object sender, EventArgs e)
        {
            contacto = txtContacto.Text;
            telefono = mskTelefono.Text;
            cont++;
            lstDatos.Items.Add(cont + ". " + contacto + " - " + telefono);

            txtContacto.Clear();
            mskTelefono.Clear();
            txtContacto.Focus();
        }

        private void frmContacto_Load(object sender, EventArgs e)
        {

        }
    }
}
