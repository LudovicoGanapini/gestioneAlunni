using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestioneAlunni
{
    internal class scuola
    {
        public string nome;
        public string indirizzo;
        public DateTime apertura;
        public DateTime chiusura;
        public List<alunno> lstAlunni;

        public string toString(scuola p)
        {
            string s = "";
            s = p.nome +" "+ p.indirizzo + " " + p.apertura.ToString() + " " + p.chiusura.ToString() + " " + p.lstAlunni.ToString();
            return s;
        }

        
    }
}
