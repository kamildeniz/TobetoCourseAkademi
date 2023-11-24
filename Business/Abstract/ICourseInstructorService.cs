using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICourseInstructorService
    {
        IDataResult<List<CourseInstructor>> GetAll();
        IDataResult<List<CourseInstructor>> GetByCourseId(int id);
        IDataResult<List<CourseInstructor>> GetByInstructorId(int id);
        IResult Add(CourseInstructor courseInstructor);
        IResult Update(CourseInstructor courseInstructor);
        IResult Delete(CourseInstructor courseInstructor);
    }
}
