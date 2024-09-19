
using System.Runtime.Serialization;

namespace Model
{

    [DataContract]
    public class ActivoFijoBuilder
    {
        [DataMember]
        public ActivoFijo activoFijo { get; private set; }

        public ActivoFijoBuilder(string codigo, string nombre, double precio)
        {
            this.activoFijo = new ActivoFijo
            {
                Codigo = codigo,
                Nombre = nombre,
                Precio = precio
            };
        }

        public ActivoFijoBuilder ConMarca(string marca)
        {
            this.activoFijo.Marca = marca;
            return this;
        }

        public ActivoFijoBuilder ConProveedor(string proveedor)
        {
            this.activoFijo.Proveedor = proveedor;
            return this;
        }

        public ActivoFijoBuilder ConNumeroExistentes(int numeroExistentes)
        {
            this.activoFijo.NumeroExistentes = numeroExistentes;
            return this;
        }

        public ActivoFijoBuilder ConVidaUtilAños(int vidaUtilAños)
        {
            this.activoFijo.VidaUtilAños = vidaUtilAños;
            return this;
        }

        public ActivoFijoBuilder ConUbicacion(string ubicacion)
        {
            this.activoFijo.Ubicacion = ubicacion;
            return this;
        }

        // Método que construye la instancia de ActivoFijo
        public ActivoFijo Build()
        {
            return this.activoFijo;
        }
    }
}
