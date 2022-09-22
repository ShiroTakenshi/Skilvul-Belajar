using System;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    class Program
    {
        static void Main(String[] args)
        {
            string proses;
            do
            {
                Console.WriteLine("  Input Number  : ");
                Console.WriteLine("(1.)  Pertambahan ");
                Console.WriteLine("(2.)  Pengurangan ");
                Console.WriteLine("(3.)  Perkalian   ");
                Console.WriteLine("(4.)  Pembagian   ");


                int nilai;
                Console.Write("Input Nilai Awal : ");
                int input1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input Nilai Kedua : ");
                int input2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Masukkan nomor yang akan di pilih : ");
                string symbol = Console.ReadLine();

                switch (symbol)
                {
                    case "1":
                        nilai = input1 + input2;
                        Console.WriteLine("Pertambahan : " + nilai); break;
                    case "2":
                        nilai = input1 - input2;
                        Console.WriteLine("Pengurangan : " + nilai); break;
                    case "3":
                        nilai = input1 - input2;
                        Console.WriteLine("Perkalian : " + nilai); break;
                    case "4":
                        nilai = input1 - input2;
                        Console.WriteLine("Pembagian : " + nilai); break;
                }
                Console.ReadLine();
                Console.Write("Ingin Lanjutkan ? (y)");
                proses = Console.ReadLine();
            }
            while (proses == "y" || proses == "Y");
        }
    }
}