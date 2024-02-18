using DataAccess.Abstracts;
using Entities;

namespace DataAccess.Concretes.EntityFramework;

public class EfCategoryDal : ICategoryDal
{
    List<Category> categories;

    public EfCategoryDal()
    {
        Category category1 = new Category
        {
            Id = 1,
            Languages = "C#",
            Technology = ".NET Core"
        };

        Category category2 = new Category
        {
            Id = 2,
            Languages = "JAVA",
            Technology = "Hibernate"
        };

        Category category3 = new Category
        {
            Id = 3,
            Languages = "Python",
            Technology = "Django"
        };

        categories = new List<Category> { category1, category2, category3 };
    }

    public void Add(Category category)
    {
        categories.Add(category);
        Console.WriteLine("EntityFramework ile eklendi " + category.Languages);
    }

    public void Delete(int id)
    {
        categories.SingleOrDefault(c => c.Id == id);
        categories.Remove(GetById(id));


    }

    public List<Category> GetAll()
    {
        return categories;

    }

    public Category GetById(int id)
    {
        return categories.SingleOrDefault(c=>c.Id == id);
    }

    public void Update(Category category)
    {
        Category existingCategory = categories.SingleOrDefault(c => c.Id == category.Id);

        if (existingCategory != null)
        {
            existingCategory.Languages = category.Languages;
            existingCategory.Technology = category.Technology;

            Console.WriteLine("EntityFramework ile güncellendi: " + category.Languages);
        }
        else
        {
            Console.WriteLine("Güncellenecek kategori bulunamadı!");
        }
    }
}
