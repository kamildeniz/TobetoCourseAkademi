using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCourseDal : EfEntityRepositoryBase<Course, TobetoContext>, ICourseDal
    {
        public List<CourseDetailDTO> GetCourseDetails()
        {
            using (TobetoContext context = new())
            {
                var result = from c in context.Courses
                             join cat in context.Categories
                             on c.CategoryId equals cat.Id
                             select new CourseDetailDTO
                             {
                                 CategoryName = cat.Name,
                                 CourseId = c.Id,
                                 CourseName = c.Name,
                                 Description = c.Description,
                                 Price = c.Price
                             };
                return result.ToList();
            }
            
        }
    }
}
