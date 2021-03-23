using System;
using System.Collections.Generic;
using System.Text;

namespace CoreCourse.EfBasics.Domain.Entities
{
    public class Course
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public Teacher Teacher { get; set; }
    }
}
