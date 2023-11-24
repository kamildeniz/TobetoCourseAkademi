using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IInstructorService
    {
        IDataResult<List<Instructor>> GetAll();
        IResult Add(Instructor instructor);
        IResult Update(Instructor instructor);
        IResult Delete(Instructor instructor);
    }
}
