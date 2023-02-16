using System;

namespace Lib_torte
{
    public class Torta
    {
        protected string Nome;
        double _peso;
        protected double Peso { get { return _peso; } set { _peso = value < 0 ? 0 : value; } }
        protected double Tempo_preparazione;

        public Torta(string nome, double peso, double t)
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
        public string GetNome()
        {
            return Nome;
        }

        public virtual double Prezzo()
        {
            return 0;
        }
    }
}
