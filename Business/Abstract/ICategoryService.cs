using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Concrete.DTOs;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        IDataResult<List<Category>> GetAll();
        IDataResult<Category> GetById(int id);
        IResult Add(CategoryDTO categoryDTO);
        IResult Update(CategoryDTO categoryDTO);
        IResult Delete(int id);
    }
}
