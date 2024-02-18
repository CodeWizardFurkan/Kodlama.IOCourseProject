using Business.Concretes;
using DataAccess.Concretes.EntityFramework;
using Entities;

//-------------------------------------CourseManager-------------------------------------

CourseManager courseManager = new CourseManager(new EfCourseDal());

//courseManager.Add(new Course { Id = 4, CategoryId = 1, InstructorId = 1, ImageUrl = "5.jpg", CourseName = "Deneme", Complete = "&70"});

//courseManager.Delete(1);

//courseManager.Update(new Course { Id = 1, CategoryId = 1, InstructorId =1, ImageUrl = "5.jpg", CourseName = "Deneme1", Complete = "%70"});

//Console.WriteLine(courseManager.GetById(1).CourseName);


foreach (var course in courseManager.GetAll())
{
    //Console.WriteLine(course.Id + " " + course.CourseName);
}

//-------------------------------------CategoryManager-------------------------------------

CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

//categoryManager.Add(new Category { Id = 4, Languages = "Javascript", Technology = "Node.js" });

//categoryManager.Delete(1);

//categoryManager.Update(new Category { Id = 1, Languages = "Deneme", Technology = "Deneme" });

//Console.WriteLine(categoryManager.GetById(1).Languages);

foreach (var category in categoryManager.GetAll())
{
    //Console.WriteLine(category.Id + " " + category.Languages);
}

//-------------------------------------InstructorManager-------------------------------------

InstructorManager instructorManager = new InstructorManager(new EfInstructorDal());

//instructorManager.Add(new Instructor { Id = 2, FirstName = "Furkan", LastName = "Demir" });

//instructorManager.Delete(1);

//instructorManager.Update(new Instructor { Id = 1, FirstName = "Deneme", LastName = "Deneme" });

//Console.WriteLine(instructorManager.GetById(1).FirstName);

foreach (var instructor in instructorManager.GetAll())
{
    //Console.WriteLine(instructor.Id + " " + instructor.FirstName + " " + instructor.LastName);
}



