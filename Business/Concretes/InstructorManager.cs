using Business.Abstracts;
using DataAccess.Abstracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes;

public class InstructorManager : IInstructorService
{
    private readonly IInstructorDal _instructorDal;

    public InstructorManager(IInstructorDal instructorDal)
    {
        _instructorDal = instructorDal;
    }

    public void Add(Instructor instructor)
    {
        _instructorDal.Add(instructor);
    }

    public void Delete(int id)
    {
        _instructorDal.Delete(id);
    }

    public List<Instructor> GetAll()
    {
        return _instructorDal.GetAll(); 
    }

    public Instructor GetById(int id)
    {
        return _instructorDal.GetById(id);
    }

    public void Update(Instructor instructor)
    {
        _instructorDal.Update(instructor);
    }
}
