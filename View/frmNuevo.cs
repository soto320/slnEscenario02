using Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class frmNuevo : Form
    {
        private readonly ActivoFijoController Controlador;
        public frmNuevo()
        {
            InitializeComponent();
            this.Controlador = new ActivoFijoController();
        }

        private void frmNuevo_Load(object sender, EventArgs e)
        {

        }
        private int ParseInt(string num, String campo)
        {
            int result = 0;
            try
            {
                result = int.Parse(num);
            }
            catch (Exception )
            {

                throw new Exception($"Este campo admite solo enteros {campo}!");
            }
            return result;
        }
        private double ParseDouble(string num, String campo)
        {
            double result = 0;
            try
            {
                result = double.Parse(num);
            }
            catch (Exception )
            {

                throw new Exception($"Este campo admite solo decimales  {campo}!");
            }
            return result;
        }
        private void AddNuevo()
        {
            try
            {
                Controlador.CrearActivoFijo(this.txtCodigo.Text, this.txtNombre.Text, this.ParseDouble(this.txtPrecio.Text, "Precio"), this.txtMarca.Text, this.txtProveedor.Text, this.txtUbicacion.Text, this.ParseInt(this.txtVidaUtil.Text, "Vida Util"), this.ParseInt(this.txtNumeroExistente.Text, "Num. Existentes"));
                Controlador.SerializarListaActivosFijos();
            }
            catch (Exception e)
            {

                MessageBox.Show($"Error: {e.Message}");
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.AddNuevo();
        }
    }
}
