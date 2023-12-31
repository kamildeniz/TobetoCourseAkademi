﻿
using Core.Entities;

namespace Entities.Concrete
{
    public class Course : IEntity
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
        public List<CourseInstructor> CourseInstructors { get; set; }
    }
}
