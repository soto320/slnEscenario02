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

        public ActivoFijo(ActivoFijoBuilder builder)
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
    }
}
