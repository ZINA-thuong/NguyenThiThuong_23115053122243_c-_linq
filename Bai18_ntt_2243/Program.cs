using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai18_ntt_2243
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
            Console.WriteLine("Nguyen Thi Thuong _23115053122243_LTC#02");

            List<Student> danhSachSV = new List<Student>() {
                new Student { Id = 1, Name = "An", Score = 8 },
                new Student { Id = 2, Name = "Binh", Score = 6 },
                new Student { Id = 3, Name = "Chi", Score = 9 },
                new Student { Id = 4, Name = "Dung", Score = 4 }
            };
            Console.WriteLine("Danh sach sv ban dau");
            foreach (Student sv in danhSachSV)
                Console.WriteLine(sv.Name + "-" + sv.Score);

            //Phân nhóm giỏi khá trung bình
            var PhanLoai = danhSachSV.GroupBy(s => s.Score >= 8 ? "GIOI" : ( s.Score >= 6 ? "KHA" : "TRUNG BINH"));
            
            foreach(var group in PhanLoai)
            {
                Console.WriteLine($"=={group.Key}==");
                foreach(var sv in group)
                {
                    Console.WriteLine($"{sv.Name} - {sv.Score}");//
                }
            }

            Console.ReadLine();
        }
    }
}
