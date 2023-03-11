using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Oefentoets1
{
    public class Register<T>
    {
        private List<T> _registraties = new List<T>();
        private T[] _mutaties = new T[5];

        public void Toevoegen(T item)
        {
            _registraties.Add(item);
        }

        public IEnumerable<string> RekeningNummers(Banken bank, int aantal)
        {
            return Enumerable.Empty<string>();
        }

        public bool OngedaanMaken()
        {
            return false;
        }


        public bool Verwijderen(T item)
        {
            return false;
        }
    }
}