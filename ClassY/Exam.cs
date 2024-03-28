using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassY
{
    public class Exam
    {
        public string ImtahanAdi { get; set; }
        public int Bal { get; set; }


        public Exam(string imtahanadi,int bal)
        {
            ImtahanAdi= imtahanadi;
            Bal= bal;
        }
    }
}
