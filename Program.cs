using System;

namespace Esercizi2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Istanzio oggetto
            Calcolatrice c = new Calcolatrice();

            //Creo delegate per inserimento dati
            Action val = () => {Console.WriteLine("Inserire primo valore: "); int x = Convert.ToInt32(Console.ReadLine()); c.N = x;};
            Action val2 = () => {Console.WriteLine("Inserire secondo valore: "); int y = Convert.ToInt32(Console.ReadLine()); c.K = y;};

            //Eseguo delegate
            val();
            val2();

            //Restituisco risultato operazioni in Tupla Unnamed
            var MyOperation = ($"Addizione: {c.Addizione()}, Sottrazione: {c.Sottrazione()}, Moltiplicazione: {c.Moltiplicazione()}, Divisione: {c.Divisione()}");
            Console.WriteLine(MyOperation);

        }       
    }
}
