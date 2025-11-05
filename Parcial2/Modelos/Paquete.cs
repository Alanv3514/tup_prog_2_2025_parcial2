using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2.Modelos
{
    public class Paquete
    {
        //NroRegistro, Peso y ZonaDestino como propiedad
        public int NroRegistro { get; set; }
        public double Peso { get; set; }
        public int ZonaDestino { get; set; }

        //Constructor que inicializa las propiedades
        public Paquete(int id, double peso, int zona)
        {
            this.NroRegistro = id;
            this.Peso = peso;
            this.ZonaDestino = zona;
        }
        public override string ToString()
        {
            //retorno como csv para aprovechar mas adelante 
            return $"{NroRegistro};{Peso};{ZonaDestino}";
        }
    }
}
