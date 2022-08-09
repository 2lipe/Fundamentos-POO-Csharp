using System;
using System.Collections.Generic;
using System.Text;

namespace POO.Context
{
    public class Career : Content
    {
        public Career(string title, string url) : base(title, url)
        {
            CareerItems = new List<CareerItem>();
        }

        public IList<CareerItem> CareerItems { get; set; }
        public int TotalCourses => CareerItems.Count;
    }
}
