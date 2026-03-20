using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_NguyenThiThuong_23115053122243
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nguyen Thi Thuong _ 23115053122243 _ 225LTC#02");
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 78, 8 };

            List<int> SoLon5 = numbers.Where(n => n > 5).ToList();
            Console.WriteLine("Danh sach so > 5: " + string.Join(", ", SoLon5));
            Console.ReadLine();
        }
    }
}
