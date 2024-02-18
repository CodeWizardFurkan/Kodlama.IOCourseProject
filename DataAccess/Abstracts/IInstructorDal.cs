using Entities;

namespace DataAccess.Abstracts;

public interface IInstructorDal
{
    List<Instructor> GetAll();
    Instructor GetById(int id);
    void Add(Instructor instructor);
    void Update(Instructor instructor);
    void Delete(int id);
}
