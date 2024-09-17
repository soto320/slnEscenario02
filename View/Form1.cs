using Controller;
using Model;
using System.Diagnostics;

namespace View
{
    public partial class Form1 : Form
    {
        private ActivoFijoController Controlador;
        private string filePath = "listaActivosFijos.xml";
        public Form1()
        {
            InitializeComponent();
            this.Controlador = new ActivoFijoController();
            MostrarListaActivosFijos();
        }
        public void MostrarActivoFijos(Model.ActivoFijo activoFijo)
        {
            Debug.Write(activoFijo);
        }

        public void MostrarMensajes(string mensaje)
        {
            Debug.Write(mensaje);
        }
        public void MostrarListaActivosFijos()
        {
            try
            {
                var listaActivosFijos = Controlador.DeserializarListaActivosFijos(filePath);
                if (listaActivosFijos.Count() == 0)
                {
                    Controlador.CrearActivoFijo("C-001", "Computador", 1200.00, "Apple", "Proveedor XYZ");
                    Controlador.CrearActivoFijo("M-001", "Mesa", 500.00, "Ikea", "Proveedor ABC");
                    Controlador.CrearActivoFijo("A-001", "Auto", 25000.00, "Toyota", "Proveedor DEF");
                    Controlador.SerializarListaActivosFijos(filePath);
                }
                if (listaActivosFijos.Count == 0)
                {
                    MostrarMensajes("No hay activos fijos registrados.");
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


    }

}
