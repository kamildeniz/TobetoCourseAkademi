using Business.Abstract;
using Business.Constants;
using Business.ValidationsRules.FluentValidation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.DTOs;

namespace Business.Concrete
{
    public class CourseManager : ICourseService
    {
        private ICourseDal _course;

        public CourseManager(ICourseDal course)
        {
            _course = course;
        }
        public IDataResult<List<Course>> GetAll()
        {
            return new SuccessDataResult<List<Course>>(_course.GetAll());
        }
         public IDataResult<Course> GetById(int id)
        {
            return new SuccessDataResult<Course>(_course.Get(c=>c.Id==id));
        }

        public IDataResult<List<Course>> GetByUnitPrice(int min, int max)
        {
            return new SuccessDataResult<List<Course>>(_course.GetAll(p => p.Price >= min && p.Price <= max));
        }

        public IDataResult<List<Course>> GetByCategoryId(int id)
        {
            return new SuccessDataResult<List<Course>>(_course.GetAll(p => p.CategoryId == id));
        }

        public IResult Add(CourseDTO courseDTO)
        {
            CourseValidator validationRules = new CourseValidator();
            validationRules.Validate(courseDTO);
            Course course = new Course
            {
                Name = courseDTO.Name,
                CategoryId = courseDTO.CategoryId,
                Description = courseDTO.Description,
                Price = courseDTO.Price
            };
            _course.Add(course);
            return new SuccessResult();
        }

        public IResult Update(CourseDTO courseDTO)
        {
            Course course = new Course
            {
                Name = courseDTO.Name,
                CategoryId = courseDTO.CategoryId,
                Description = courseDTO.Description,
                Price = courseDTO.Price
            };
            _course.Update(course);
            return new SuccessResult();
        }

        public IResult Delete(int id)
        {
            _course.Delete(GetById(id).Data);
            //Console.WriteLine("Course deleted successfully.");
            return new SuccessResult(Messages.Deleted);
        }
    }
}
