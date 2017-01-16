using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium
{
    class Podroz : IStacja
    {
        protected Stack<Stacja> stacje = new Stack<Stacja>();
        protected double koszt = 100;
        public Podroz() { }
        public virtual double KosztPoRabacie()
        {
            return 0.9 * koszt;
        }

        public void DodajStacje(string nazwa, bool oplata)
        {
            stacje.Push (new Stacja (nazwa,oplata ));
            if (oplata == true)
                koszt += 15;

        }

        public void Powrot()
        {
         
        }

        public void UsunStacje()
        {
            stacje.Pop();
        }

        public void ZapiszPodroz()
        {
            
        }
    }
}
