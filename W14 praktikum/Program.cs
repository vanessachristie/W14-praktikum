using System;

namespace W14_praktikum
{
    
    class Program
    {
        public static void Menu ()
        {
            Console.Write("input : ");
        }
        public static void Menu2()
        {
            Console.Write("output : ");
        }
        public static void CekPrima (int angka)
        {
            Console.WriteLine("Angka Prima");
            int jumlahBagi = 0;
            int temp = 0;
            int apakahPrima = 0;
            for (int i = 0; i < angka; i++)
            {
                for (int j = 0; j < angka; j++)
                {
                    apakahPrima = 0;
                    while (apakahPrima == 0)
                    {
                        temp++;
                        jumlahBagi = 0;
                        for (int c = 1; c <= temp; c++)
                        {
                            if (temp % c == 0)
                            {
                                jumlahBagi++;
                            }
                        }
                        if (jumlahBagi == 2)
                        {
                            apakahPrima = 1;
                        }
                        else
                        {
                            apakahPrima = 0;
                        }
                    }
                    Console.Write($"{temp} ".PadLeft(5));
                }
                Console.WriteLine();
            }
        }
        public static void CekNonPrima(int angka)
        {
            Console.WriteLine("Bukan Angka Prima");
            int jumlahBagi = 0;
            int temp = 0;
            int apakahPrima = 0;
            for (int i = 0; i < angka; i++)
            {
                for (int j = 0; j < angka; j++)
                {
                    apakahPrima = 0;
                    while (apakahPrima == 0)
                    {
                        temp++;
                        jumlahBagi = 0;
                        for (int c= 1; c <= temp; c++)
                        {
                            if (temp % c == 0)
                            {
                                jumlahBagi++;
                            }
                        }
                        if (jumlahBagi == 2)
                            apakahPrima = 0;
                        else
                            apakahPrima = 1;
                    }
                    Console.Write($"{temp} ".PadLeft(4));
                }
                Console.WriteLine();
            }

        }

        static void Main(string[] args)
        {
            Menu();
            int angka =Convert.ToInt32(Console.ReadLine());
            while (angka < 2)
            {
                Console.WriteLine("Input salah, coba lagi");
                angka = Convert.ToInt32(Console.ReadLine());
            }
                Menu2();
                int HasilBagi = 0;
                int m = angka / 2;
                for (int i = 2; i <= m; i++)
                {
                    if (angka % i == 0)
                    {
                        HasilBagi += 1;
                    }
                }

                if (HasilBagi == 0)
                {
                    CekPrima (angka);
                }
                else
                {
                    CekNonPrima(angka);
                }
            }

        }
    }