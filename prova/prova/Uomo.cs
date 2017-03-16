using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova
{
    public class Uomo
    {
        private string _nome;                                 //dichiaro le varie proprietà in scrittura e lettura 
        public string nome { get; set; }

        private string _cognome;
        public string cognome { get; set; }

        private int _anni;
        public int anni                                      //procedimenti per eventuali se 
        {  
            set
            {
                if (value < 0) value = 10;
                anni = value; 
            }

            get { return anni; }
        }

        public Uomo (string nome, string cognome, int anni)                    //costruttore con i vari this 
        {
            this.nome = nome;
            this.cognome = cognome;
            this.anni = anni; 
        }

        public virtual string describe()                             //eventuale funzione describe (VIRTUAL per override nel figlio)
        {
            string output = "Nome: " + nome + "\r\n";
            output += "Cognome: " + cognome + "\r\n";
            output += "anni: " + anni + "\r\n";
            return output;
        }

        public override string ToString()                                   //override del tostring
        {
            return (nome + " " + cognome + " " + anni).ToString();
        }

    }
}


 /* if (curHp <= 0)                                                           //se-allora
            {
                Console.WriteLine("Non puoi curare nessuno da morto");
                return;
            } */