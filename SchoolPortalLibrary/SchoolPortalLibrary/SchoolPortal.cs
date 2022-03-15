﻿using Newtonsoft.Json;
using System.Net;

namespace SchoolPortalLibrary
{
    public class SchoolPortal
    {
        double MinAVG(string[] marks)
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
            return Math.Round( sum / count,0);
        }
        int GetCountTruancy(List<Mark> marks)
        {
            int count = 0;
            foreach (var item in marks)
            {
                if (item.Estimation == "прогул")
                {
                    count++;
                }
            }
            return count;
        }
        int GetCountDisease(List<Mark> marks)
        {
            int count = 0;
            foreach (var item in marks)
            {
                if (item.Estimation == "болезнь")
                {
                    count++;
                }
            }
            return count;
        }
        string GetStudNumber(int year, int group, string fio)
        {
            string initial = "";
            try
            {
                initial = fio.Split(' ')[0] + " " + fio.Split(' ')[1][0] + "." + fio.Split(' ')[2][0] + ".";
            }
            catch
            {
            }
            return year + "." + group +"." + initial;
        }
        List<Mark> GetMarks(DateTime now, List<Students> students)
        {
            List<Mark> marks = new List<Mark>();
            for (int i = 0; i < 10; i++)
            {
                marks.Add(new Mark(now, (new Random()).Next(1, 6).ToString()));
                now = now.AddDays(1);
            }
            return marks;
        }
    }
}