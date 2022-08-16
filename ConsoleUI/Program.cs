using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;



ProductTest();
//CategoryTest();



static void ProductTest()
{
    Console.WriteLine("PRODUCT NAME");
    ProductManager productManager = new ProductManager(new EfProductDal(),new CategoryManager(new EfCategoryDal()));

    var result = productManager.GetProductDetails();

    if (result.Success == true)
    {
        foreach (var product in result.Data)
        {
            Console.WriteLine(product.ProductName + "\\" + product.CategoryName);
        }
    }

    else
    {
        Console.WriteLine(result.Message);
    }
    Console.WriteLine();

}




static void CategoryTest()
{
    Console.WriteLine("Category Name");
    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
    foreach (var category in categoryManager.GetAll().Data)
    {
        Console.WriteLine(category.CategoryName);
    }
}
Console.ReadLine();