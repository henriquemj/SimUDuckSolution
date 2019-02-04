using System;

namespace SimUDuck.Patos
{
    public abstract class Pato
    {
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public void Grasnar()
        {
            Console.WriteLine("Grasnando");
        }

        public void Voar()
        {
            Console.WriteLine("Voando");
        }
        public void Nadar()
        {
            Console.WriteLine("Nadando");
        }
        public void Nadar(string nome)
        {
            Console.WriteLine(nome + "Nadando");
        }
    }
}
