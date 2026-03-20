using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai17_ntt_2243
{
    
    class Program
    {
        class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public double Score { get; set; }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nguyen Thi Thuong _23115053122243_LTC#02");//
            
            List<Student> danhSachSV = new List<Student>() {
                new Student { Id = 1, Name = "An", Score = 8 },
                new Student { Id = 2, Name = "Binh", Score = 6 },
                new Student { Id = 3, Name = "Chi", Score = 9 },
                new Student { Id = 4, Name = "Dung", Score = 7 }
            };
            Console.WriteLine("Danh sach sv ban dau");
            foreach (Student sv in danhSachSV)
                Console.WriteLine(sv.Name + "-" + sv.Score);

            //Tính điểm trung bình
            var diemTB = danhSachSV.Average(s => s.Score);
            Console.WriteLine($"Diem trung binh sv: {diemTB}");
            Console.ReadLine();
        }
    }
}
