### Nguyễn Duy Quảng ###
## MSSV: K215480106139 ##
## Đề bài: Bài toán tính tiền điện ##
# Sử dụng ConsoleAPP #
```p
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    internal class Program
    {
        static double TinhTienDien(int N)
        {
            //Bai toan: Tinh tien dien
            //input: so dien
            //output: so tien
            //thuat toan:
            //if so dien 0< so dien <=50: so tien = so dien * 1806
            //if so dien 51<= so dien <= 100: so tien = so dien * 1866
            //if so dien 101<= so dien <= 200: so tien = so dien * 2167
            //if so dien 201<= so dien <= 300: so tien = so dien * 2729
            //if so dien 301<= so dien <= 400: so tien = so dien * 3050
            //if so dien so dien => 401: so tien = so dien * 3151

            const int SO_BAC = 6;
            
            int[] nguong = { 0, 50, 100, 200, 300, 400 };

            double[] gia = { 1806, 1866, 2167, 2729, 3050, 3151 };
            double tienDien = 0;


            for (int i = SO_BAC - 1; i >= 0; i--)
            {
                if (N > nguong[i])
                {
                    tienDien += (N - nguong[i]) * gia[i];
                    N = nguong[i];
                }
            }

            return tienDien;
        }
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("CHƯƠNG TRÌNH TÍNH TIỀN ĐIỆN");

            Console.Write("Nhập số điện (kWh): ");
            int N = int.Parse(Console.ReadLine());  

            double tienPhaiTra = TinhTienDien(N);  
            Console.WriteLine("Số tiền phải trả: " + tienPhaiTra + " đồng");  
            Console.ReadKey();  
        }
    }
}
```
![image](https://github.com/user-attachments/assets/25bd85f4-58f7-4662-82d8-b95ecf31e36f)

# Chia sử dụng DLL #
```p
using System;
using System.Collections.Generic;
using System.Text;

namespace lib_TinhTienDien
{
    public class cls_TienDien
    {
        //input 
        public double N;
        //output
        public double tiendien { get; private set; }
        public double TinhTienDien()
        {
            const int SO_BAC = 6;

            int[] nguong = { 0, 50, 100, 200, 300, 400 };

            double[] gia = { 1806, 1866, 2167, 2729, 3050, 3151 };
            tiendien = 0;


            for (int i = SO_BAC - 1; i >= 0; i--)
            {
                if (N > nguong[i])
                {
                    tiendien += (N - nguong[i]) * gia[i];
                    N = nguong[i];
                }
            }

            return tiendien;
        }
    }
}

```
# Web sau khi được sử dụng DLL #
```p

![image](https://github.com/user-attachments/assets/269930e6-b42e-4329-8d7e-9015f60aac3c)

```
