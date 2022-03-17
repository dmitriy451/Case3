using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Students
    {
        public Students(string year, string group, string fio)
        {
            Year = year;
            Group = group;
            Fio = fio;
        }
        public string Year { get; set; }
        public string Group { get; set; }
        public string Fio { get; set; }
    }
}
