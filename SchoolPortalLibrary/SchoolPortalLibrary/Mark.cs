using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPortalLibrary
{
    public class Mark
    {
        public Mark(DateTime date, string estimation)
        {
            Date = date;
            Estimation = estimation;
        }
        public DateTime Date { get; set; }

        public string Estimation { get; set; }
    }
}
