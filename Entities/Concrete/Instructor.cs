using Core.Entities;

namespace Entities.Concrete
{
    public class Instructor : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public List<CourseInstructor>? CourseInstructors { get; set; }
    }
}