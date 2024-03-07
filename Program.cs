using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiGia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap tien usd: ");
            double usd=double.Parse(Console.ReadLine());
            Console.WriteLine("So tien sau khi doi: " + usd * 23000 + " VND");
            Console.ReadKey();
        }
    }
}
