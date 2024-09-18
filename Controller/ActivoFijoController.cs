using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Diagnostics;

namespace Controller
{
    public class ActivoFijoController
    {

        private List<ActivoFijo> ListaActivoFijo;
        private readonly string FilePath = "listaActivosFijos.xml";

        public ActivoFijoController()
        {

            this.CargarActivoFijo();
        }
        private void CargarActivoFijo() {
            if (File.Exists(FilePath))
            {
                this.ListaActivoFijo= DeserializarListaActivosFijos();
            }
            else
            {
                // Si el archivo no existe, devuelve una lista vacía
                this.ListaActivoFijo=new List<ActivoFijo>();
            }
        }

        public void CrearActivoFijo(string codigo, string nombre, double precio, string marca, string proveedor,string ubicacion, int vidaUtil, int numExistente)
        {


            ActivoFijo activo = new ActivoFijoBuilder(codigo, nombre, precio)
                .ConMarca(marca)
                .ConProveedor(proveedor)
                .ConUbicacion(ubicacion)
                .ConVidaUtilAños(vidaUtil)
                .ConNumeroExistentes(numExistente)
                .Build();
            ListaActivoFijo.Add(activo);
        }

        public void SerializarListaActivosFijos()
        {
            try
            {
                DataContractSerializer serializer = new DataContractSerializer(typeof(List<ActivoFijo>));
                using (FileStream stream = new FileStream(FilePath, FileMode.Create))
                {
                    serializer.WriteObject(stream, ListaActivoFijo);
                }
                Debug.Write("Lista de activos fijos serializada correctamente a XML.");
            }
            catch (Exception ex)
            {
                Debug.Write($"Error al serializar: {ex.Message}");
            }
        }

        public List<ActivoFijo> DeserializarListaActivosFijos()
        {
            try
            {
                DataContractSerializer serializer = new DataContractSerializer(typeof(List<ActivoFijo>));
                using (FileStream stream = new FileStream(FilePath, FileMode.Open))
                {
                    Debug.Write("Lista de activos fijos deserializada correctamente desde XML.");
                    return ListaActivoFijo = (List<ActivoFijo>)serializer.ReadObject(stream);
                }
               
               
            }
            catch (Exception ex)
            {
                Debug.Write($"Error al deserializar: {ex.Message}");
                return new List<ActivoFijo>();
            }
        }
    }
}
