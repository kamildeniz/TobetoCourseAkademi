using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CourseInstructorManager : ICourseInstructorService
    {
        private ICourseInstructorDal _courseInstructorDal;

        public CourseInstructorManager(ICourseInstructorDal courseInstructorDal)
        {
            _courseInstructorDal = courseInstructorDal;
        }

        public IDataResult<List<CourseInstructor>> GetAll()
        {
            return new SuccessDataResult<List<CourseInstructor>>(_courseInstructorDal.GetAll());
        }

        public IDataResult<List<CourseInstructor>> GetByCourseId(int id)
        {
            return new SuccessDataResult<List<CourseInstructor>>(_courseInstructorDal.GetAll(p => p.CourseId == id));
        }

        public IDataResult<List<CourseInstructor>> GetByInstructorId(int id)
        {
            return new SuccessDataResult<List<CourseInstructor>>(_courseInstructorDal.GetAll(p => p.InstructorId == id));
        }

        public IResult Add(CourseInstructor courseInstructor)
        {
            _courseInstructorDal.Add(courseInstructor);
            return new SuccessResult();
        }

        public IResult Update(CourseInstructor courseInstructor)
        {
            _courseInstructorDal.Update(courseInstructor);
            return new SuccessResult();
        }

        public IResult Delete(CourseInstructor courseInstructor)
        {
            _courseInstructorDal.Delete(courseInstructor);
            return new SuccessResult();
        }
    }
}
