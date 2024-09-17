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

        private List<ActivoFijo> listaActivosFijos;

        public ActivoFijoController()
        {

            this.listaActivosFijos = new List<ActivoFijo>();
        }

        public void CrearActivoFijo(string codigo, string nombre, double precio, string marca, string proveedor,string ubicacion, int vidaUtil, int numExistente)
        {
            ActivoFijo activo = new ActivoFijo.ActivoFijoBuilder(codigo, nombre, precio)
                .ConMarca(marca)
                .ConProveedor(proveedor)
                .ConUbicacion(ubicacion)
                .ConVidaUtilAños(vidaUtil)
                .ConNumeroExistentes(numExistente)
                .Build();
            listaActivosFijos.Add(activo);
        }

        public void SerializarListaActivosFijos(string filePath)
        {
            try
            {
                DataContractSerializer serializer = new DataContractSerializer(typeof(List<ActivoFijo>));
                using (FileStream stream = new FileStream(filePath, FileMode.Create))
                {
                    serializer.WriteObject(stream, listaActivosFijos);
                }
                Debug.Write("Lista de activos fijos serializada correctamente a XML.");
            }
            catch (Exception ex)
            {
                Debug.Write($"Error al serializar: {ex.Message}");
            }
        }

        public List<ActivoFijo> DeserializarListaActivosFijos(string filePath)
        {
            try
            {
                DataContractSerializer serializer = new DataContractSerializer(typeof(List<ActivoFijo>));
                using (FileStream stream = new FileStream(filePath, FileMode.Open))
                {
                    Debug.Write("Lista de activos fijos deserializada correctamente desde XML.");
                    return listaActivosFijos = (List<ActivoFijo>)serializer.ReadObject(stream);
                }
               
               
            }
            catch (Exception ex)
            {
                Debug.Write($"Error al deserializar: {ex.Message}");
                return null;
            }
        }
    }
}
