using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_NguyenThiThuong_2243
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };

            var soChan = numbers.Where(n => n % 2 == 0).ToList();
            Console.Write("Danh sach so chan: ");
            foreach (var n in soChan)
                Console.Write($"{n} ");
            Console.ReadLine();
        }
    }
}
