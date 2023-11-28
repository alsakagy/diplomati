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

            Nuovi_Diplomati[] Vettore1 = new Nuovi_Diplomati[100];
            Vecchi_Diplomati[] Vettore2 = new Vecchi_Diplomati[100];

            Console.WriteLine("quanti diplomati vuoi inserire");
            int quantità = int.Parse(Console.ReadLine());

            for(int i = 0; i < quantità; i++)
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

                while(Controllo)
                {
                    if(Voto >= 61 && Voto <= 100)
                    {
                        Vettore1[i].Inserimento_Diplomati(Nome, Cognome, Voto);
                    }
                    else if(Voto >= 36 && Voto <= 60)
                    {
                        Vettore2[i].Inserimento_Diplomati(Nome, Cognome, Voto);
                    }
                    else
                    {
                        Console.WriteLine("il voto inserito non è un voto accettabile");
                    }
                }
            }
        }
    }
}
