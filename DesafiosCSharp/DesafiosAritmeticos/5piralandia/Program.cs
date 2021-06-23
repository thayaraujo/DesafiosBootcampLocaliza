using System;

namespace Piralandia
{
    class comunicacaoPiralandia
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            char[] caracters = n.ToCharArray();

            for (int i = 1; i <= caracters.Length; i++)
            {
                Console.Write(caracters[caracters.Length - i]);
            }
        }
    }
}