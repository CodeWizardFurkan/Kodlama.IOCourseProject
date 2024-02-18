using Entities;

namespace DataAccess.Abstracts;

public interface ICategoryDal
{
    List<Category> GetAll();
    Category GetById(int id);
    void Add(Category category);
    void Update(Category category);
    void Delete(int id);
}
