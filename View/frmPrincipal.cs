using Controller;
using Model;
using System.Diagnostics;

namespace View
{
    public partial class frmPrincipal : Form
    {
        private readonly ActivoFijoController Controlador;
        private readonly string FilePath = "listaActivosFijos.xml";
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
                var listaActivosFijos = Controlador.DeserializarListaActivosFijos(FilePath);
                /* if (listaActivosFijos.Count() == 0)
                 {
                     Controlador.CrearActivoFijo("C-001", "Computador", 1200.00, "Apple", "Proveedor XYZ","S/U",2,3);
                     Controlador.SerializarListaActivosFijos(filePath);
                 }*/
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
