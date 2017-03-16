using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova
{ 
    class Lista                                                            //per creare una lista 
    { 
        public List<Uomo> elenco = new List<Uomo>();

        public void aggiungi(Uomo u)
        {
            elenco.Add(u);
        }
    }
}
}
