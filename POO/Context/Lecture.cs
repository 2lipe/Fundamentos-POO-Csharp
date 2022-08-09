using POO.Context.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace POO.Context
{
    public class Lecture : Base
    {
        public int Order { get; set; }
        public string Title { get; set; }
        public int DurationInMinutes { get; set; }
        public EContentLevel Level { get; set; }
    }
}
