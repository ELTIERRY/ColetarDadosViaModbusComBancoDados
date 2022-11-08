using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programa6
{
    public abstract class ModelDadosPrensa
    {
        public int Id { get; set; }
        public int? Prensa { get; set; }        
        public string TemperaturaPlato01 { get; set; }
        public string TemperaturaPlato02 { get; set; }
        
        protected ModelDadosPrensa()
        {
        }

        protected ModelDadosPrensa(int id, int prensa, string temperaturaPlato01, string temperaturaPlato02)
        {
            Id = id;
            Prensa = prensa;
            TemperaturaPlato01 = temperaturaPlato01;
            TemperaturaPlato02 = temperaturaPlato02;
        }

        public override string ToString()
        {
            return ($"{Id} {TemperaturaPlato01} {TemperaturaPlato02} ").ToString();
        }

    }
}