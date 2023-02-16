using System;
using System.Collections.Generic;
using System.Text;

namespace Lib_torte
{
    public class Torta_preparata : Torta
    {
        int _quan;
        public int Quantita { get { return _quan; } set { _quan = value > 100 ? 100 : (value < 0 ? 0 : value); } }

        public Torta_preparata(string nome, double peso, double t) : base(nome,peso,t)
        {}

        public override double Prezzo()
        {
            return Peso * Tempo_preparazione;
        }
        public bool Mangia(int fetta)
        {
            Quantita-= fetta;
            Peso = Quantita;
            return Quantita - fetta >= 0 ? true : false;
        }
    }
    
}
