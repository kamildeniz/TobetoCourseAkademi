using Core.DataAccess;
using Entities.Concrete;
using Entities.Concrete.DTOs;

namespace DataAccess.Abstract
{
    public interface ICourseDal : IEntityRepository<Course>
    {
        List<CourseDetailDTO> GetCourseDetails();
    }
}
