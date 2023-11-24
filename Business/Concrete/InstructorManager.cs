using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;


namespace Business.Concrete
{
    public class InstructorManager : IInstructorService
    {
        private IInstructorDal _instructorDal;

        public InstructorManager(IInstructorDal instructorDal)
        {
            _instructorDal = instructorDal;
        }

        public IDataResult<List<Instructor>> GetAll()
        {
            return new SuccessDataResult<List<Instructor>>(_instructorDal.GetAll());
        }

        public IResult Add(Instructor instructor)
        {
            _instructorDal.Add(instructor);
            return new SuccessResult();
        }

        public IResult Update(Instructor instructor)
        {
            _instructorDal.Update(instructor);
            return new SuccessResult();
        }

        public IResult Delete(Instructor instructor)
        {
            _instructorDal.Delete(instructor);
            return new SuccessResult();

        }
    }
}
