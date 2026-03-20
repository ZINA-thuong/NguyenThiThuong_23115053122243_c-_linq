using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5_ntt_2243
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nguyen Thi Thuong _ 23115053122243 _ 225LTC#02");
            List<int> numbers = new List<int> { 1, 52, 3, 4, 9, 6, 7, 78, 8 };
            Console.WriteLine("Danh sach ban dau: " + string.Join(", ", numbers));//

            List<int> binhPhuong = numbers.Select(n => n*n).ToList();
            Console.WriteLine("Danh sach binh phuong: " + string.Join(", ", binhPhuong));
            Console.ReadLine();
        }
    }
}
