using SimUDuck.Interfaces;
using SimUDuck.Patos;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimUDuck.Fabrica
{
   public class FabricaPatos
    {
        public List<IPato> ObterPatos()
        {
            List<IPato> patos = new List<IPato>();
            patos.Add(new PatoSelvagem());
            patos.Add(new PatoReal());

            return patos;

        }
    }
}
