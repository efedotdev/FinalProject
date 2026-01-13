using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    internal class Program
    {
        //SOLID
        //Open Closed Principle
        static void Main(string[] args)
        {
            //CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            //foreach (var category in categoryManager.GetAll())
            //{
            //    Console.WriteLine(category.CategoryName);
            //}

            ProductManager productManager = new ProductManager(new EfProductDal(),new CategoryManager(new EfCategoryDal()));
            //foreach (var product in productManager.GetByUnitPrice(20,100))
            //{
            //    Console.WriteLine(product.ProductName);

            //}
            //CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            //Console.WriteLine(categoryManager.GetById(4).CategoryName.ToString());
            //var result = productManager.GetProductDetails();
            //if (result.Success==true)
            //{
            //    foreach (var product in result.Data)
            //    {
            //        Console.WriteLine("{0} / {1}", product.ProductName, product.CategoryName);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(result.Message);
            //}

            //foreach (var product in productManager.GetProductDetails().Data)
            //{
            //    Console.WriteLine("{0} / {1}", product.ProductName, product.CategoryName);
            //},
            Product p = new Product
            {
                ProductName = "Asus Laptop",
                CategoryId = 5,
                UnitsInStock = 15,
                UnitPrice = 15000
            };
            Console.WriteLine(productManager.Add(p).Message);

        }
    }
}
