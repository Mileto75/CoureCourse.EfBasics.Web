using System;
using System.Collections.Generic;
using System.Text;

namespace CoreCourse.EfBasics.Domain.Entities
{
    public class Teacher
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public decimal YearlyWage { get; set; }
        public int DepartmentId { get; set; }
        public string HomeTown { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
