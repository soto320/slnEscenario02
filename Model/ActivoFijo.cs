using System.Runtime.Serialization;


namespace Model
{
    [DataContract]
    public class ActivoFijo
    {
        [DataMember]
        public string Codigo { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public double Precio { get; set; }
        [DataMember]
        public string Marca { get;  set; }
        [DataMember]
        public string Proveedor { get;  set; }
        [DataMember]
        public int NumeroExistentes { get;  set; }
        [DataMember]
        public int VidaUtilAños { get;  set; }
        [DataMember]
        public string Ubicacion { get;  set; }

        public override string ToString()
        {
            return $"ActivoFijo: {Nombre} (Código: {Codigo}, Precio: {Precio:C}, Marca: {Marca ?? "N/A"}, " +
                   $"Proveedor: {Proveedor ?? "N/A"}, Número Existente: {NumeroExistentes}, " +
                   $"Vida Útil: {(VidaUtilAños > 0 ? VidaUtilAños.ToString() : "N/A")}, " +
                   $"Ubicación: {Ubicacion ?? "N/A"})";
        }
    }
}
