using Controller;
using Model;
using System.Diagnostics;

namespace View
{
    public partial class frmPrincipal : Form
    {
        private readonly ActivoFijoController Controlador;
        public frmPrincipal()
        {
            InitializeComponent();
            this.Controlador = new ActivoFijoController();
            MostrarListaActivosFijos();
        }
        public void MostrarListaActivosFijos()
        {
            try
            {
                var listaActivosFijos = Controlador.DeserializarListaActivosFijos();
                if (listaActivosFijos.Count == 0)
                {
                    Debug.Write("No hay activos fijos registrados.");
                }
                else
                {
                    this.dataGridView.DataSource = listaActivosFijos;

                }
            }
            catch (Exception e)
            {

                MessageBox.Show($" Error: {e.Message}");
            }
        }

        private void mnNuevo_Click(object sender, EventArgs e)
        {
            frmNuevo frm = new frmNuevo();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.MostrarListaActivosFijos();
            }
        }
    }

}
