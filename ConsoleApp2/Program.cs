using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("CHƯƠNG TRÌNH TÍNH TIỀN ĐIỆN");

            Console.Write("Nhập số điện (kWh): ");
            int N = int.Parse(Console.ReadLine());

            TienDien tg = new TienDien();
            tg.N = N;
            tg.TinhTienDien();

            double TienPhaiTra = tg.tiendien;
            Console.WriteLine("Số tiền phải trả: " + TienPhaiTra + " đồng");
            Console.ReadKey();
        }
    }
}
