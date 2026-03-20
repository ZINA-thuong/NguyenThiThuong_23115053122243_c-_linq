using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai19_ntt_2243
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nguyen Thi Thuong _ 23115053122243 _ 225LTC#02");
            List<int> numbers = new List<int> { 1, 2, 2, 3, 4, 4, 5 };
            Console.WriteLine("Danh sach ban dau: " + string.Join(", ", numbers));

            // PT nào xuất hiện nhiều nhất 
            var PTnhieunhat = numbers.GroupBy(n => n).OrderByDescending(g=>g.Count()).FirstOrDefault();
            Console.WriteLine($"Phan tu nhieu nhat là {PTnhieunhat.Key}: {PTnhieunhat.Count()} lan");
            Console.ReadLine();
        }
    }
}

