using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiNgoaiLe
{
    class Program
    {
        public class Khoa
        {
            public int IdKhoa { get; set; }
            public string TenKhoa { get; set; }
        }

        public class Student
        {
            public string MSV { get; set; }
            public string Ten { get; set; }
            public DateTime NgaySinh { get; set; }
            public int IdKhoa { get; set; }
            public double Diem { get; set; }
            public int SinhVienNam { get; set; }

            public int Tuoi => DateTime.Now.Year - NgaySinh.Year;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            
            var listKhoa = new List<Khoa>
            {
                new Khoa { IdKhoa = 1, TenKhoa = "Công nghệ số" },
                new Khoa { IdKhoa = 2, TenKhoa = "Kinh tế" },
                new Khoa { IdKhoa = 3, TenKhoa = "Ngoại ngữ" },
                new Khoa { IdKhoa = 4, TenKhoa = "Cơ khí" },
                new Khoa { IdKhoa = 5, TenKhoa = "Luật" }
            };

            // KHỞI TẠO 40 SINH VIÊN RANDOM
            var random = new Random();
            var listSV = new List<Student>();
            for (int i = 1; i <= 40; i++)
            {
                listSV.Add(new Student
                {
                    MSV = "SV" + i.ToString("D3"),
                    Ten = "Sinh viên " + i,
                    NgaySinh = new DateTime(random.Next(2002, 2007), random.Next(1, 13), random.Next(1, 28)),
                    IdKhoa = random.Next(1, 6),
                    Diem = Math.Round(random.NextDouble() * (10 - 4) + 4, 1), // Điểm từ 4.0 -> 10.0
                    SinhVienNam = random.Next(1, 5) 
                });
            }


            //MAX/MIN TUỔI
            var maxTuoi = listSV.Max(s => s.Tuoi);
            var minTuoi = listSV.Min(s => s.Tuoi);

            var svMaxTuoi = listSV.Where(s => s.Tuoi == maxTuoi).ToList();
            var svMinTuoi = listSV.Where(s => s.Tuoi == minTuoi).ToList();

            Console.WriteLine($"=> SV lớn tuổi nhất ({maxTuoi} tuổi): " + string.Join(", ", svMaxTuoi.Select(s => s.Ten)));
            Console.WriteLine($"=> SV trẻ tuổi nhất ({minTuoi} tuổi): " + string.Join(", ", svMinTuoi.Select(s => s.Ten)));

            // 2. KT có khoa CNS ko 
            bool coSV_CNS = listSV.Any(s => s.IdKhoa == 1);
            Console.WriteLine($"=> Có sinh viên khoa Công nghệ số không? { (coSV_CNS ? "Có" : "Không") }");

            // 3. Lấy 10 sinh viên có điểm trung bình cao nhất khoa CNS
            var top10CNS = listSV.Where(s => s.IdKhoa == 1).OrderByDescending(s => s.Diem).Take(10).ToList();

            Console.WriteLine("\n--- Top 10 SV điểm cao nhất khoa CNS ---");
            top10CNS.ForEach(s => Console.WriteLine($"{s.MSV} - {s.Ten} - Điểm: {s.Diem}"));

            // 4. Bỏ qua các sinh viên năm cuối (năm 4)
            var svChuaRaTruong = listSV.Where(s => s.SinhVienNam < 4).ToList();

            Console.WriteLine($"\n--- Danh sách SV chưa phải năm cuối (Tổng: {svChuaRaTruong.Count} SV) ---");
            svChuaRaTruong.ToList().ForEach(s => Console.WriteLine($"{s.Ten} - Năm: {s.SinhVienNam}"));
            

            Console.ReadLine();
        }
    }
}
