using System;
using Hiloscarrea;
namespace Hilos
{
    class Carrera
    {
        public  static void Competidor(object obj)
        {
            var nombre = (string)obj;

            var hiloInicial = Thread.CurrentThread;
            var sanco = 0;
            var random = new Random();

            while ( sanco < 10000 )
            {

                sanco += random.Next(0, 4);
                Console.WriteLine("Competidor {0} dio {1} sancos", nombre, sanco);
                Thread.Sleep(10);


            }
            Console.WriteLine("Comptidor  {0} llego primero ",nombre); // el resto son lentos XD
        }
    }
}
