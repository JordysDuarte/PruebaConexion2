using ClaseConexion;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {

        Conexion con = new Conexion();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProbar_Click(object sender, EventArgs e)
        {
            try   
            {
                con.AbrirConexion();
                MessageBox.Show("Conexion Exitosa");
                con.CerrarConexion();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }

           

        }
    }
}
