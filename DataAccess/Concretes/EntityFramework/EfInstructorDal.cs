using DataAccess.Abstracts;
using Entities;

namespace DataAccess.Concretes.EntityFramework;

public class EfInstructorDal : IInstructorDal
{
    List<Instructor> instructors;

    public EfInstructorDal()
    {
        Instructor instructor1 = new Instructor
        {
            Id = 1,
            FirstName = "Engin",
            LastName = "Demiroğ"
        };

        instructors = new List<Instructor> {instructor1 };
    }

    public void Add(Instructor instructor)
    {
        instructors.Add(instructor);
        Console.WriteLine("EntityFramework ile eklendi " + instructor.FirstName);

    }

    public void Delete(int id)
    {
        instructors.SingleOrDefault(i => i.Id == id);
        instructors.Remove(GetById(id));


    }

    public List<Instructor> GetAll()
    {
        return instructors;
    }

    public Instructor GetById(int id)
    {
        return instructors.SingleOrDefault(i => i.Id == id);
    }

    public void Update(Instructor instructor)
    {
        Instructor existingInstructor = instructors.SingleOrDefault(i=>i.Id == instructor.Id);

        if (existingInstructor != null)
        {
            existingInstructor.Id = instructor.Id;
            existingInstructor.FirstName = instructor.FirstName;
            existingInstructor.LastName = instructor.LastName;

            Console.WriteLine("EntityFramework ile güncellendi: " + instructor.FirstName);
        }
        else
        {
            Console.WriteLine("Güncellenecek eğitmen bulunamadı!");
        }
    }
}