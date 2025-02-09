using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balta.ContentContext
{
    public class CarrerItem
    {
        public CarrerItem(int ordem, string title, string descrioption, Course course)
        {
            Ordem = ordem;
            Title = title;
            Descrioption = descrioption;
            Course = course;
        }

        public int Ordem { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Descrioption { get; set; } = string.Empty;

        public Course Course { get; set; }
    }
}
