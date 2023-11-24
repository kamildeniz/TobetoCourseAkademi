using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.DTOs
{
    public class CourseDetailDTO:IDTO
    {
        public int CourseId { get; set; }
        public string CategoryName { get; set; }
        public string CourseName { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }
}
