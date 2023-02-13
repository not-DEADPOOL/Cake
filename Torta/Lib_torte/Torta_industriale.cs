using System;
using System.Collections.Generic;
using System.Text;

namespace Lib_torte
{
    public class Torta_industriale:Torta
    {
        double prezzo;
        public Torta_industriale(double p,string nome, double peso, double t) : base(nome, peso, t)
        {
            prezzo = p;
        }
        public override double Prezzo()
        {
            return prezzo*Tempo_preparazione;
        }
    }
}
