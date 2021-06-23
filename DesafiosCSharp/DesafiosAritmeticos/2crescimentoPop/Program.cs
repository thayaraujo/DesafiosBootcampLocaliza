using System;
using System.Collections.Generic;


namespace DesafiosAritmeticos
{
    public class CrescimentoPopulacional
    {
        public static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            double[] arrayList = new double[4];
            int pa, pb;
            double cpa, cpb;
            int anos;

            for (int i = 0; i < t; i++)
            {
                anos = 0;
                string[] valores = Console.ReadLine().Split();
                pa = int.Parse(valores[0]);
                pb = int.Parse(valores[1]);
                
                cpa = 1 + double.Parse(valores[2])/100.0;
                cpb = 1 + double.Parse(valores[3])/100.0;
                
                while (pa <= pb && anos <= 100)
                {
                    pa = (int)(pa * cpa);
                    pb = (int)(pb * cpb);
                    anos++;

                        if (anos > 100)
                        {
                            Console.WriteLine("Mais de 1 seculo.");
                            break;
                        }
                }

                if (anos <= 100)
                {
                    Console.WriteLine("{0:0} anos.", anos);
                    
                }
            }
        }
    }
}