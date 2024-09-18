using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;


namespace Model
{
    [DataContract]
    public class ActivoFijo
    {
        [DataMember]
        public string Codigo { get; private set; }
        [DataMember]
        public string Nombre { get; private set; }
        [DataMember]
        public double Precio { get; private set; }
        [DataMember]
        public string Marca { get; private set; }
        [DataMember]
        public string Proveedor { get; private set; }
        [DataMember]
        public int NumeroExistentes { get; private set; }
        [DataMember]
        public int VidaUtilAños { get; private set; }
        [DataMember]
        public string Ubicacion { get; private set; }

        private ActivoFijo(ActivoFijoBuilder builder)
        {
            Codigo = builder.Codigo;
            Nombre = builder.Nombre;
            Precio = builder.Precio;
            Marca = builder.Marca;
            Proveedor = builder.Proveedor;
            NumeroExistentes = builder.NumeroExistentes;
            VidaUtilAños = builder.VidaUtilAños;
            Ubicacion = builder.Ubicacion;
        }

        public override string ToString()
        {
            return $"ActivoFijo: {Nombre} (Código: {Codigo}, Precio: {Precio:C}, Marca: {Marca ?? "N/A"}, " +
                   $"Proveedor: {Proveedor ?? "N/A"}, Número Existente: {NumeroExistentes}, " +
                   $"Vida Útil: {(VidaUtilAños > 0 ? VidaUtilAños.ToString() : "N/A")}, " +
                   $"Ubicación: {Ubicacion ?? "N/A"})";
        }

        [DataContract]
        public class ActivoFijoBuilder
        {
            [DataMember]
            public string Codigo { get; private set; }
            [DataMember]
            public string Nombre { get; private set; }
            [DataMember]
            public double Precio { get; private set; }
            [DataMember]
            public string Marca { get; private set; }
            [DataMember]
            public string Proveedor { get; private set; }
            [DataMember]
            public int NumeroExistentes { get; private set; }
            [DataMember]
            public int VidaUtilAños { get; private set; }
            [DataMember]
            public string Ubicacion { get; private set; }

            public ActivoFijoBuilder(string codigo, string nombre, double precio)
            {
                Codigo = codigo;
                Nombre = nombre;
                Precio = precio;
            }

            public ActivoFijoBuilder ConMarca(string marca)
            {
                Marca = marca;
                return this;
            }

            public ActivoFijoBuilder ConProveedor(string proveedor)
            {
                Proveedor = proveedor;
                return this;
            }

            public ActivoFijoBuilder ConNumeroExistentes(int numeroExistentes)
            {
                NumeroExistentes = numeroExistentes;
                return this;
            }

            public ActivoFijoBuilder ConVidaUtilAños(int vidaUtilAños)
            {
                VidaUtilAños = vidaUtilAños;
                return this;
            }

            public ActivoFijoBuilder ConUbicacion(string ubicacion)
            {
                Ubicacion = ubicacion;
                return this;
            }

            public ActivoFijo Build()
            {
                return new ActivoFijo(this);
            }
        }
    }
}
