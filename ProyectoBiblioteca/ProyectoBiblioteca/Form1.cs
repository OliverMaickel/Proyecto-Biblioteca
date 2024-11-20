using System.Collections;

namespace ProyectoBiblioteca
{
    public partial class frmVentas : Form
    {
        static string[] libros = { "Cien años de soledad", "1984", "El Principito", "Matar a un ruiseñor", "Orgullo y prejuicio", "El Alquimista", "Crimen y castigo", "El Gran Gatsby" };
        
        //ARRAY OBJETO
        ArrayList aLibro = new ArrayList(libros);

        //CLASE VENTAS OBJ
        Ventas objv = new Ventas();

        //TOTAL
        double total;
        
        
        public frmVentas()
        {
            InitializeComponent();
        }

        
        private void frmVentas_Load(object sender, EventArgs e)
        {
            MostrarFecha();
            MostrarHora();
            LimpiarCampos();
            lblTotalNeto.Text = "0.00";
            LlenarLibros();
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Datos para la clase ventas
            objv.Libro = cobLibro.Text;
            objv.Cantidad = int.Parse(txtCantidad.Text);

            ListViewItem fila = new ListViewItem(objv.Libro);
            fila.SubItems.Add(objv.Cantidad.ToString());
            fila.SubItems.Add(objv.AsignarPrecio().ToString("C"));
            fila.SubItems.Add(objv.CalcularSubTotal().ToString("C"));
            fila.SubItems.Add(objv.CalcularDescuento().ToString("C"));
            fila.SubItems.Add(objv.CalcularNeto().ToString("C"));
            lvRegistro.Items.Add(fila);

            //SUMA DE SUBTOTALLLLL
            total += objv.CalcularNeto();
            lblTotalNeto.Text = total.ToString("C");

            LimpiarCampos();


        }
        private void cobLibro_SelectedIndexChanged(object sender, EventArgs e)
        {
            objv.Libro = cobLibro.Text;
            lblPrecio.Text = objv.AsignarPrecio().ToString("C");
        }

        private void MostrarFecha()
        {
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void MostrarHora()
        {
            lblHora.Text = DateTime.Now.ToShortTimeString();
        }

        private void LimpiarCampos()
        {
            txtCliente.Clear();
            cobLibro.Text = "Seleccione un libro";
            txtCantidad.Clear();
            lblPrecio.Text = "0.00";
            txtCliente.Focus();
        }

        private void LlenarLibros()
        {
            foreach (var p in aLibro)
            {
                cobLibro.Items.Add(p);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Deseas cancelar?", "Venta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                LimpiarCampos();
            }
        }    
    }
}
