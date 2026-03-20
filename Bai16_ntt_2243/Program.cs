using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai16_ntt_2243
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nguyen Thi Thuong _ 23115053122243 _ 225LTC#02");
            List<int> numbers = new List<int> { 1, 2, 2, 3, 4, 4, 5 };
            Console.WriteLine("Danh sach ban dau: " + string.Join(", ", numbers));

            // tinh tong 
            var Tong = numbers.Sum();
            
            Console.WriteLine($"Tong cac phan tu trong danh sach: {Tong}");
            Console.ReadLine();
        }
    }
}
