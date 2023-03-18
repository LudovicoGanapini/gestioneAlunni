using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestioneAlunni
{
    internal class alunno
    {
        

        public string nome;
        public string cognome;
        public int età;
        public string città;

        //metodi

        public string toString(alunno p)
        {
            string s = "";
            s = p.nome + " " + p.cognome + " " + p.età.ToString() + " " + p.città;
            return s;
        }
        
        public string classi(alunno p)
        {
            string s = "";

            if (p.età < 16)
            {
                s = "Biennio";
            }
            else
            {
                s = "Triennio";
            }
            return s;
        }
    }
}
