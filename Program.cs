using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2FebbraioTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //messaggio di benvenuto all'avvio del programma
            Console.WriteLine("Benvenuto sul portale dell'agenzia delle entrate.");

            //richiamo il metodo per chiedere i dati all'utente
            Operazioni.InserimentoDati();

            Operazioni.StampaRisultati();
        }
    }
}
