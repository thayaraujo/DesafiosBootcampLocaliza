using System;

namespace desafioMultiplos
{
    class pinkCerebro
    {
        static void Main(string[] args)
        {
            var casosDeTeste = int.Parse(Console.ReadLine());
            string[] multiplos = Console.ReadLine().Split();
           
            int numero;
            int multiploDois = 0, multiploTres = 0, multiploQuatro = 0, multiploCinco = 0;   
                                      
                foreach (var teste in multiplos)
                {
                  numero = int.Parse(teste);
                  
                    if (numero % 2 == 0)
                        multiploDois++;

                    if (numero % 3 == 0)
                        multiploTres++;
                    
                    if (numero % 4 == 0)
                        multiploQuatro++;
                    
                    if (numero % 5 == 0)
                        multiploCinco++;
                }
                                                       
                Console.WriteLine("{0} Multiplo(s) de 2\n", multiploDois);
                Console.WriteLine("{0} Multiplo(s) de 3\n", multiploTres);
                Console.WriteLine("{0} Multiplo(s) de 4\n", multiploQuatro);
                Console.WriteLine("{0} Multiplo(s) de 5\n", multiploCinco);
        }
    }
}