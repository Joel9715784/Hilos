using System;
using Hiloscarera;

namespace Hilos
{
    class Program
    {
         public static void Main(string[] args)
        {
            Console.WriteLine("PAIRIKI");
           

            Thread competidor1 = new Thread(Carrera.Competidor);
            Thread competidor2 = new Thread(Carrera.Competidor);
            Thread competidor3= new Thread(Carrera.Competidor);
            Thread competidor4= new Thread(Carrera.Competidor);

            competidor1.Start();
            competidor2.Start();
            competidor3.Start();
            competidor4.Start();

            competidor1.Join();
            competidor2.Join();
            competidor3.Join();
            competidor4.Join();



        }

        static void Ejecturar()
        {
            

            var hiloInicial = Thread.CurrentThread; 
            hiloInicial.CurrentCulture = new System.Globalization.CultureInfo("en-US"); 
            Console.WriteLine("Hilo en curso {0}: ", hiloInicial.ManagedThreadId); 

            Console.WriteLine("Mi cultura es  {0} ", hiloInicial.CurrentCulture); 

            var random = new Random();
            for (int i =0; i <= 10; i++)
            {
                Console.WriteLine("HILO {0} ix {1}", hiloInicial.ManagedThreadId, i);

                Thread.Sleep(random.Next(500,2000));
            }

        }
    }
}
