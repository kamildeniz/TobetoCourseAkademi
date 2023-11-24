using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Concrete.DTOs;

namespace Business.Abstract
{
    public interface ICourseService
    {
        IDataResult<List<Course>> GetAll();
        IDataResult<List<Course>> GetByUnitPrice(int min, int max);
        IDataResult<List<Course>> GetByCategoryId(int id);
        IDataResult<Course> GetById(int id);
        IResult Add(CourseDTO courseDTO);
        IResult Update(CourseDTO courseDTO);
        IResult Delete(int id);

    }
}
