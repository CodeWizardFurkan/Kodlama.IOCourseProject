using DataAccess.Abstracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework;

public class EfCourseDal : ICourseDal
{
    List<Course> courses;

    public EfCourseDal()
    {
        Course course1 = new Course
        {
            Id = 1,
            CategoryId = 1,
            InstructorId = 1,
            ImageUrl = "1.jpg",
            CourseName = "Yazılım Geliştirici Yetiştirme Kampı C#",
            Complete = "%60"
        };

        Course course2 = new Course
        {
            Id = 2,
            CategoryId = 2,
            InstructorId = 1,
            ImageUrl = "2.jpg",
            CourseName = "Yazılım Geliştirici Yetiştirme Kampı JAVA",
            Complete = "%50"
        };

        Course course3 = new Course
        {
            Id = 3,
            CategoryId = 3,
            InstructorId = 1,
            ImageUrl = "3.jpg",
            CourseName = "Yazılım Geliştirici Yetiştirme Kampı Python",
            Complete = "70"
        };

        courses = new List<Course> { course1, course2, course3};
    }

    public void Add(Course course)
    {
        courses.Add(course);
        Console.WriteLine("EntityFramework ile eklendi " + course.CourseName);
    }

    public void Delete(int id)
    {
        courses.SingleOrDefault(c=>c.Id == id);
        courses.Remove(GetById(id));

    }

    public List<Course> GetAll()
    {
        return courses;
        
    }

    public Course GetById(int id)
    {
        return courses.SingleOrDefault(c =>c.Id == id);
    }

    public void Update(Course course)
    {
        Course existingCourse = courses.SingleOrDefault(c => c.Id == course.Id);

        if (existingCourse != null)
        {
            existingCourse.Id = course.Id;
            existingCourse.CategoryId = course.CategoryId;
            existingCourse.InstructorId = course.InstructorId;
            existingCourse.ImageUrl = course.ImageUrl;
            existingCourse.CourseName = course.CourseName;
            existingCourse.Complete = course.Complete;

            Console.WriteLine("EntityFramework ile güncellendi: " + course.CourseName);
        }
        else
        {
            Console.WriteLine("Güncellenecek kurs bulunamadı!");
        }
    }
}
