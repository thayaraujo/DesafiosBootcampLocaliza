using System;
using System.Collections.Generic;
using System.Linq;

namespace DesafioMercado
{
    class Program
    {
        public static void Main(string[] args)
        {
            var totalDeCasosDeTeste = int.Parse(Console.ReadLine());
            
            for(int i = 0; i < totalDeCasosDeTeste; i++)
            {
              List<string> mercado = new List<string>(Console.ReadLine().Split(' '));  
              List<string> mercadoSemDuplicados = mercado.Distinct().ToList();
                
                mercadoSemDuplicados.Sort();  
                foreach(string item in mercadoSemDuplicados)
                {
                    Console.Write($"{item} ");
                }

                Console.WriteLine("");
           
            }
        }
    }
}