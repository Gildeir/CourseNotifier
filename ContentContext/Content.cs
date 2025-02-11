using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseNotifier.SharedContext;

namespace CourseNotifier.ContentContext
{
    public abstract class Content : BaseContent
    {
        public Content(string title, string url)
        {
            Title = title;
            Url = url;
        }
        public string Title { get; set; }

        public string Url { get; set; }
    }
}
