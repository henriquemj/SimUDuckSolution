using System;
using System.Collections.Generic;
using System.Text;
using SimUDuck.Interfaces;

namespace SimUDuck.Patos
{
    class PatoReal : IPato
    {
        void IPato.Grasnar()
        {
            Console.WriteLine("Pato real está grasnando");
        }

        void IPato.Nadar()
        {
            Console.WriteLine("Pato real está nadando");
        }

        void IPato.Nadar(string nome)
        {
            Console.WriteLine(nome + "Pato real está nadando");
        }

        void IPato.Voar()
        {
            Console.WriteLine("Pato real está voando");
        }
    }
}
