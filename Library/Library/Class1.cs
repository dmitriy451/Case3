using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Class1
    {
        public double MinAVG(string[] marks)
        {
            double sum = 0;
            double count = 0;
            foreach (var item in marks)
            {
                try
                {
                    sum += Convert.ToInt32(item);
                    count++;
                }
                catch
                {

                }
            }
            return Math.Round(sum / count, 2);
        }
        public int GetCountTruancy(List<Mark> marks)
        {
            int count = 0;
            foreach (var item in marks)
            {
                if (item.Estimation == "Прогул")
                {
                    count++;
                }
            }
            return count;
        }
        public int GetCountDisease(List<Mark> marks)
        {
            int count = 0;
            foreach (var item in marks)
            {
                if (item.Estimation == "Болезнь")
                {
                    count++;
                }
            }
            return count;
        }
        public string GetStudNumber(string year, string group, string fio)
        {
            string initial = "";
            try
            {
                initial = fio.Split(' ')[0] + " " + fio.Split(' ')[1][0] + "." + fio.Split(' ')[2][0] + ".";
            }
            catch
            {
            }
            return year + "." + group + "." + initial;
        }
        public List<Mark> GetMarks(DateTime now, List<Students> students)
        {
            Random random = new Random();
            List<Mark> marks = new List<Mark>();
            for (int i = 0; i < 10; i++)
            {
                marks.Add(new Mark(now, (random.Next(2, 6).ToString())));
                now = now.AddDays(1);
            }
            return marks;
        }
    }
}
