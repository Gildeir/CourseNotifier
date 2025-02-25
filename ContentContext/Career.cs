﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseNotifier.ContentContext
{
    public class Career : Content
    {
        public Career (string title, string url) : base(title, url)
        {
            Items = new List<CarrerItem>();
        }
        public IList<CarrerItem> Items { get; set; }

        public int TotalCourses => Items.Count;
    }
}
