using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneScuola.Entities
{
    internal class Studente
    {
        public int IdStudente { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public DateTime DataNascita { get; set; }
        public Studente()
        {

        }
        public Studente(int idStudente, string nome, string cognome, DateTime dataNascita)
        {
            IdStudente = idStudente;
            Nome = nome;
            Cognome = cognome;     
            DataNascita = dataNascita;

        }
        public Studente(string nome)
        {
            Nome = nome;
        }
        public override string ToString()
        {
            return $"ID n.{IdStudente} - Nome:{Nome}, Cognome: {Cognome}";
        }


    }
}
