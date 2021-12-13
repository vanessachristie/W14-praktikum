using System;

namespace W14_praktikum
{
    
    class Program
    {
        public static int Input ()
        { 
            int input = Convert.ToInt32(Console.ReadLine());
            return input;
        }
        public static void Menu ()
        {
            Console.Write("input : ");
        }
        public static void Menu2()
        {
            Console.Write("output : ");
        }

        static void Main(string[] args)
        {
            Menu();
            int angka = Input();
            Menu2();
            int HasilBagi = 0;
            int m = angka / 2;
            bool Prima = true;
            for (int i = 2; i <= m; i++)
            {
                if (angka % i == 0)
                {
                    HasilBagi += 1;
                }
            }

            if (HasilBagi == 0)
            {
                Console.WriteLine("Angka prima");
                int[,] angkaPrima = new int[angka, angka];
                for (int i = 2; i <= 1000; i++)
                {
                    for (int j = 2; j < i; j++)
                    {
                        if ((i % j) == 0)
                        {
                            Prima = false;
                            break;
                        }
                    }
                    if (Prima)
                        Console.Write(+i + "  ");
                    Prima = true;
                }
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Bukan angka prima");
                for (int i = 1; i <= angka; i++)
                {
                    for (int j = 1; j <= angka; j++)
                    {
                        if (i == j && i % j != 0)
                        {
                            Prima = true;
                            Console.Write("\t" + i);
                        }
                    }
                    if (Prima)
                    {
                        Console.Write(String.Format("{0,6}", (i)));
                    }
                    Prima = true;
                }
                Console.ReadKey();
            }


        }
    }
}
