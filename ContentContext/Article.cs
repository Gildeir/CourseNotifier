﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseNotifier.ContentContext
{
    public class Article : Content
    {
        public Article(string title, string url) :base(title, url)
        {
            
        }
        public string Name { get; set; }

    }
}
