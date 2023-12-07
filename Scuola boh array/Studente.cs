using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scuola_boh_array
{
    internal class Studente
    {
        private string matricola;
        private string nome;
        private string cognome;
        private const int dimensione=10;
        private int[] voti = new int[dimensione];
        private string[] materie =
        {
        "italiano",
        "storia",
        "matematica",
        "inglese",
        "informatica",
        "tecnologie",
        "sistemi e reti",
        "telecomunicazioni",
        "scienze motorie",
        "educazione civica",
        };

        public Studente(string matricola, string nome, string cognome, int[] v)
        {
            this.matricola = matricola;
            this.nome = nome;
            this.cognome = cognome;
            Random V = new Random();
            voti[0] = V.Next(1, 11);
            voti[1] = V.Next(1, 11);
            voti[2] = V.Next(1, 11);
            voti[3] = V.Next(1, 11);
            voti[4] = V.Next(1, 11);
            voti[5] = V.Next(1, 11);
            voti[6] = V.Next(1, 11);
            voti[7] = V.Next(1, 11);
            voti[8] = V.Next(1, 11);
            voti[9] = V.Next(1, 11);
        }
        public string GetNome()
        {
            return nome;
        }
        public string GetCognome()
        {
            return cognome;
        }
        public string[] GetMaterie()
        {
            return materie;
        }
        public string GetMatricola()
        {
            return matricola;
        }
        public int calcolamedia(int media)
        {
            for (int i = 0; i < dimensione; i++)
            {
                media += voti[i];
            }
            media = media / dimensione;
            return media;
        }
        //manca da fare il voto minimo, voto massimo, to string e la roba nel main.
        public int[] min
    }
}
