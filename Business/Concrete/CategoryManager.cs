using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.Concrete.DTOs;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categorydal;

        public CategoryManager(ICategoryDal categorydal)
        {
            _categorydal = categorydal;
        }


        public IDataResult<List<Category>> GetAll()
        {
            return new SuccessDataResult<List<Category>>(_categorydal.GetAll(), Messages.Listed);
        }

        public IResult Add(CategoryDTO categoryDTO)
        {
            _categorydal.Add(new (){Name=categoryDTO.Name, Description=categoryDTO.Description});
            return new SuccessResult(Messages.Added);
        }

        public IResult Update(CategoryDTO categoryDTO)
        {
            _categorydal.Update(new(){Id=categoryDTO.Id, Name = categoryDTO.Name, Description = categoryDTO.Description});
            return new SuccessResult(Messages.Updated);
        }

        public IResult Delete(int id)
        {
            ICourseService courseService = new CourseManager(new EfCourseDal());
            List<Course> courses = courseService.GetByCategoryId(id).Data;

            if (courses == null || courses.Count == 0)
            {
                _categorydal.Delete(GetById(id).Data);
                return new SuccessResult(Messages.Deleted);
            }
            else
            {
                // Console.WriteLine("Silme işlemi iptal edildi.");
                return new ErrorResult(Messages.UnDeleted);
            }
        }

        public IDataResult<Category> GetById(int id)
        {
            return new SuccessDataResult<Category>(_categorydal.Get(cat => cat.Id==id),Messages.Listed);
        }
    }
}
