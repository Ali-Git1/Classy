using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassY
{
    public class Student
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Fakulte { get; set; }
        public int ImtahanBali { get; set; }
        public int EvvelkiBal { get; set; }
        public char Netice { get; set; }


        public Student(string ad, string soyad, string fakulte, int imtahanbali ,int evvelkibal)
        {
            Ad = ad;
            Soyad = soyad;
            Fakulte = fakulte;
            ImtahanBali = imtahanbali;
            EvvelkiBal = evvelkibal;
            Netice = ' ';
        }



        public void CheckExam()
        {
            int ferq = ImtahanBali - EvvelkiBal;
            if (ImtahanBali >= 17)
            {
                if (ImtahanBali >= 90)
                    Netice = 'A';
                else if (ImtahanBali >= 80)
                    Netice = 'B';
                else if (ImtahanBali >= 70)
                    Netice = 'C';
                else if (ImtahanBali >= 60)
                    Netice = 'D';
                else if (ImtahanBali >= 50)
                    Netice = 'E';
            }
            else
            {
                Netice = 'F'; 
            }
        }


        public void StudentInfo()
        {
            Console.WriteLine($"Adi - {Ad}");
            Console.WriteLine($"Soyadi - {Soyad}");
            Console.WriteLine($"Fakulte - {Fakulte}");
            Console.WriteLine($"Imtahan Bali - {ImtahanBali}");
            Console.WriteLine($"Netice - {Netice}");
        }
    }
}
