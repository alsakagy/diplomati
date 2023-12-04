using System;
using System.Collections.Generic;
using System.Linq;
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

        public void Stampa_Ammessi()
        {

        }
        public void Stampa_Diplomati()
        {

        }
    }
    class Nuovi_Diplomati : Diplomati
    {

    }
    class Vecchi_Diplomati : Diplomati
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            bool Controllo = true;
            int nuovi = 0, vecchi = 0;

            Nuovi_Diplomati[] Vettore1 = new Nuovi_Diplomati[100];
            Vecchi_Diplomati[] Vettore2 = new Vecchi_Diplomati[100];
            Nuovi_Diplomati Studente1 = new Nuovi_Diplomati();
            Vecchi_Diplomati Studente2 = new Vecchi_Diplomati();

            Console.WriteLine("quanti diplomati vuoi inserire");
            int quantità = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantità; i++)
            {
                // inserimento dati
                string Nome, Cognome;
                int Voto;
                Console.WriteLine("Inserisci il nome del diplomato");
                Nome = Console.ReadLine();
                Console.WriteLine("Inserisci il Cognome del diplomato");
                Cognome = Console.ReadLine();
                Console.WriteLine("Inserisci il voto del diplomato");
                Voto = int.Parse(Console.ReadLine());

                while (Controllo)
                {
                    if (Voto >= 61 && Voto <= 100)
                    {
                        Studente1.Inserimento_Diplomati(Nome, Cognome, Voto);
                        Vettore1[nuovi] = Studente1;
                        Controllo = false;
                    }
                    else if (Voto >= 36 && Voto <= 60)
                    {
                        Studente2.Inserimento_Diplomati(Nome, Cognome, Voto);
                        Vettore2[vecchi] = Studente2;
                        Controllo = false;
                    }
                    else
                    {
                        Console.WriteLine("il voto inserito non è un voto accettabile, rinserisci il voto del diplomato");
                        Voto = int.Parse(Console.ReadLine());
                    }
                }
                Console.ReadLine();
            }
        }
    }
}