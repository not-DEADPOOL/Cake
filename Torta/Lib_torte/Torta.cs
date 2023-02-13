using System;

namespace Lib_torte
{
    public class Torta
    {
        protected string Nome;
        protected double Peso;
        protected double Tempo_preparazione;

        public Torta(string nome, double peso,double t)
        {
            Tempo_preparazione = t;
            Nome = nome;
            Peso = peso;
        }

        public Torta(string nome, double peso)
        {
            Tempo_preparazione = 120.00;
            Nome = nome;
            Peso = peso;
        }
        public virtual double Prezzo()
        {
            return 0;
        }
    }
}
