using SimUDuck.Interfaces;

namespace SimUDuck
{
   public class Simulador
    {
       public void Executar(IPato pato)
        {
            pato.Grasnar();
            pato.Nadar();
            pato.Voar();
        }
    }
}
