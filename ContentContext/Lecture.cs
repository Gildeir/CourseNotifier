using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseNotifier.SharedContext;

namespace CourseNotifier.ContentContext
{
    public class Lecture: BaseContent
    {
        public int Order { get; set; }

        public string Title { get; set; } = string.Empty;

        public int DurationInMinutes { get; set; }
    }
}
