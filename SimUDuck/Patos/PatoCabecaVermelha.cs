using System;
using SimUDuck.Interfaces;

namespace SimUDuck.Patos
{
    class PatoCabecaVermelha : IPato
    {
        public void Grasnar()
        {
            Console.WriteLine("Pato Cabeça Vermelha está grasnando");
        }

        public void Nadar()
        {
            Console.WriteLine("Pato Cabeça Vermelha está nadando");
        }

        public void Nadar(string nome)
        {
            Console.WriteLine(nome + "Pato Cabeça Vermelha está nadando");
        }

        public void Voar()
        {
            Console.WriteLine("Pato Cabeça Vermelha está voando");
        }
    }
}
