using System;

namespace ProsteDodawanie
{
    class Program
    {
        
        int[] liczby = new int[100];
        int n, x;
        int total;

        int[] suma = new int[100];

        static void Main(string[] args)
        {
            Program pp = new Program();
            pp.total = 0;
            pp.n = Convert.ToInt32(Console.ReadLine());
            if(pp.n > 0 && pp.n < 100)
            {
                for(int i = 0; i < pp.n; i++)
                {
                    pp.total = 0;
                    pp.x = Convert.ToInt32(Console.ReadLine());

                    var data = Console.ReadLine();

                    foreach(var liczby in data.Split(' '))
                    {
                        var n = Convert.ToInt32(liczby);
                        pp.total += n;

                    }
                    pp.suma[i] =pp.total;
                }

                for(int i = 0; i < pp.n; i++ )
                {
                    Console.WriteLine(pp.suma[i]);
                }
            }
            Console.ReadKey();
        }

        }
    }
}
