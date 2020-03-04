using System;
using System.IO;
using System.Numerics;

namespace Esercizio
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int c = 0;
                int j = 0;
                int d = 0;
                string fileinput = "input.txt";
                string fileoutput = "output.txt";
                string num = " ";
                int n;
                char stop;
                string numero = "";
                BigInteger x = new BigInteger();
                int i = 0;

                if (File.Exists(fileinput))
                {
                    using (StreamReader reader = new StreamReader(fileinput))
                    {
                        num = reader.ReadLine();
                    }
                }

                using (StreamWriter w = new StreamWriter(fileoutput))
                {

                    do
                    {
                        string lunghezza = "";
                        j = i;
                        d = 0;
                        numero = "";
                        do
                        {
                            stop = num[j];
                            j++;
                            d++;
                        } while (stop != '1');

                        for (c = j; c < j + d - 1; c++)
                        {
                            lunghezza += int.Parse(num[c].ToString());
                        }

                        n = int.Parse(lunghezza);

                        for (i = c; i < c + n; i++)
                        {
                            numero += num[i ].ToString();
                        }

                        x = BigInteger.Parse(numero);

                        w.WriteLine(x);

                        Console.WriteLine($"{x}");

                    } while (num[i] != '*');

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}