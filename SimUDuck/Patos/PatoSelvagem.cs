using SimUDuck.Interfaces;
using System;

namespace SimUDuck.Patos
{
    class PatoSelvagem : IPato
    {
        public void Grasnar()
        {
            Console.WriteLine("PatoSelvagem está grasnando");
        }

        public void Nadar()
        {
            Console.WriteLine("PatoSelvagem está nadando");
        }

        public void Nadar(string nome)
        {
            Console.WriteLine(nome + "PatoSelvagem está nadando");
        }

        public void Voar()
        {
            Console.WriteLine("PatoSelvagem está voando");
        }
    }
}
