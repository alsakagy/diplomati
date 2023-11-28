using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace diplomati
{
    class Diplomati
    {
        protected string _Nome;
        protected string _Cognome;
        protected int _Voto;

        public void Inserimento_Diplomati(string a, string b, int c)
        {
            _Nome = a;
            _Cognome = b;
            _Voto = c;
        }
        public void Stampa_Diplomati(Diplomati[] a)
        {
            if (a[0]._Voto >= 60)
            {
                Console.WriteLine("Studenti nuovi diplomati:");
                foreach (Diplomati studente in a)
                {
                    Console.WriteLine($"Nome e cognome: {studente._Nome} {studente._Cognome} Voto: {studente._Voto}/100");
                }
            }
            else
            {
                Console.WriteLine("Studenti nuovi diplomati:");
                foreach (Diplomati studente in a)
                {
                    Console.WriteLine($"Nome e cognome: {studente._Nome} {studente._Cognome} Voto: {studente._Voto}/59");
                }
            }
        }
        public void Stampa_Ammessi(Diplomati[] a)
        {
            if (a[0]._Voto >= 60)
            {
                Console.WriteLine("Diplomati nuovi ammessi hai concorsi:");
                foreach (Diplomati studente in a)
                {
                    if (studente._Voto >= 70)
                        Console.WriteLine($"Nome e cognome: {studente._Nome} {studente._Cognome} Voto: {studente._Voto}/100");
                }
            }
            else
            {
                Console.WriteLine("Diplomati vecchi ammessi hai concorsi:");
                foreach (Diplomati studente in a)
                {
                    if (studente._Voto >= 42)
                        Console.WriteLine($"Nome e cognome: {studente._Nome} {studente._Cognome} Voto: {studente._Voto}/60");
                }
            }
        }
    }
    class Nuovi_Diplomati : Diplomati
    {
        //public Nuovi_Diplomati()
        //{
        //    _Nome = "";
        //    _Cognome = "";
        //    _Voto = 0;
        //}

        // Possibile aggiunta di funzioni uniche per nuovi (non è questo il caso)
    }
    class Vecchi_Diplomati : Diplomati
    {
        //public Vecchi_Diplomati()
        //{
        //    _Nome = "";
        //    _Cognome = "";
        //    _Voto = 0;
        //}

        // Possibile aggiunta di funzioni uniche per vecchi (non è questo il caso)
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Nuovi_Diplomati[] Vettore_Nuovi = new Nuovi_Diplomati[100];
            Vecchi_Diplomati[] Vettore_Vecchi = new Vecchi_Diplomati[100];

            bool Controllo = true;

            Console.WriteLine("quanti diplomati vuoi inserire");
            int quantità = int.Parse(Console.ReadLine());

            Console.WriteLine("Inserisci il nome del diplomato");
            string Nome = Console.ReadLine();
            Console.WriteLine("Inserisci il Cognome del diplomato");
            string Cognome = Console.ReadLine();
            Console.WriteLine("Inserisci il voto del diplomato");
            int Voto = int.Parse(Console.ReadLine());

            // Controllo voto
            while (Controllo)
            {
                if (Voto >= 36 && Voto <= 100)
                {
                    Controllo = false;
                }
                else
                {
                    Console.WriteLine("il voto inserito non è valido, inserisci un numero tra 36 e 100");
                    Voto = int.Parse(Console.ReadLine());
                }
            }

            // inserimento e divisione dei dati
            for (int i = 0; i < quantità; i++)
            {
                if (Voto >= 61)
                {
                    if(Vettore_Nuovi != null)
                        Vettore_Nuovi[i].Inserimento_Diplomati(Nome, Cognome, Voto);
                }
                else
                {
                    if (Vettore_Nuovi != null)
                        Vettore_Vecchi[i].Inserimento_Diplomati(Nome, Cognome, Voto);
                }
            }

            Console.WriteLine("\n----------------------------------------------------------\n");

            // Stampa dei diplomati
            for (int i = 0; i < quantità; ++i)
            {
                if (Vettore_Nuovi[i] != null)
                {
                    if (Vettore_Nuovi != null)
                        Vettore_Nuovi[i].Stampa_Diplomati(Vettore_Nuovi);
                }
                else if (Vettore_Vecchi[i] != null)
                {
                    if (Vettore_Nuovi != null)
                        Vettore_Vecchi[i].Stampa_Diplomati(Vettore_Vecchi);
                }
            }

            Console.WriteLine("\n----------------------------------------------------------\n");

            // Spampa dei diplomati con accesso hai concorsi
            for (int i = 0; i < quantità; ++i)
            {
                if (Vettore_Nuovi[i] != null)
                {
                    Vettore_Nuovi[i].Stampa_Ammessi(Vettore_Nuovi);
                }
                else if (Vettore_Vecchi[i] != null)
                {
                    Vettore_Vecchi[i].Stampa_Ammessi(Vettore_Vecchi);

                }
            }
        }
    }
}