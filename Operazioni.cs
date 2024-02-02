using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2FebbraioTest
{
    internal class Operazioni
    {
        //creo un nuovo oggetto
        static Contribuente contribuente1 = new Contribuente();

        //creo un metodo per chiedere i dati all'utente
        public static void InserimentoDati() 
        {
           

            //chiedo all'utente i dati necessari
            Console.WriteLine("Inserisci nome: ");
            contribuente1.Nome = Console.ReadLine();

            Console.WriteLine("Inserisci cognome: ");
            contribuente1.Cognome = Console.ReadLine();

            Console.WriteLine("Inserisci data di nascita: ");
            Console.WriteLine("(gg/mm/aaaa)");
            contribuente1.DataNascita = Console.ReadLine();

            Console.WriteLine("Inserisci codice fiscale: ");
            contribuente1.CodiceFiscale = Console.ReadLine().ToUpper();

            Console.WriteLine("Inserisci sesso: ");
            Console.WriteLine("(digitare m 0 f)");
            contribuente1.Sesso = Console.ReadLine().ToUpper();

            Console.WriteLine("Inserisci comune di residenza: ");
            contribuente1.ComuneResidenza = Console.ReadLine();

            Console.WriteLine("Inserisci redditto annuale: ");
            contribuente1.RedditoAnnuale = Convert.ToInt32(Console.ReadLine());

        }

        //creo un metodo per stampare i risultati
        public static void StampaRisultati()
        {
            Console.WriteLine("=======================\n");
            Console.WriteLine($"Contribuente: {contribuente1.Nome} {contribuente1.Cognome}," );
            Console.WriteLine($"nato il {contribuente1.DataNascita} ({contribuente1.Sesso}),");
            Console.WriteLine($"residente in {contribuente1.ComuneResidenza}");
            Console.WriteLine($"codice fiscale: {contribuente1.CodiceFiscale}");
            Console.WriteLine($"redditto dichiarato: {contribuente1.RedditoAnnuale}");
            Console.WriteLine($"IMPOSTA DA VERSARE: {contribuente1.CalcoloImposta()}\n");
            Console.WriteLine("=======================");


            Console.ReadLine(); 
        }
    }
}
