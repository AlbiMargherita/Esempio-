using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova
{
    class Figlio : Uomo       //classe figlia di uomo 

    {
        public string scuola { get; set; }                    //aggiunta una proprietà al figlio 

        public Figlio(string nome, string cognome, int anni, string scuola) : base(nome, cognome, anni)
        {
            this.scuola = scuola;
        }

        public override string describe()                     //eseguito l'override della funzione che descrive 

        {
            string output = "Nome: " + nome + "\r\n";
            output += "Cognome: " + cognome + "\r\n";
            output += "anni: " + anni + "\r\n";
            output += "Scuola: " + scuola + "\r\n";
            return output;
        }
    }
}
}
