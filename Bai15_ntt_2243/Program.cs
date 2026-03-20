using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai15_ntt_2243
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nguyen Thi Thuong _ 23115053122243 _ 225LTC#02");
            List<int> numbers = new List<int> { 1, 2, 2, 3 ,4, 4, 5 };
            Console.WriteLine("Danh sach ban dau: " + string.Join(", ", numbers));

            List<int> dsKhongTrung = numbers.Distinct().ToList();
            // kết quả là 1 số ko phải list danh sách  => ko dùng list , toList
            Console.WriteLine("Danh sach khong bi trung pt: " + string.Join(", ",dsKhongTrung));
            Console.ReadLine();
        }
    }
}
