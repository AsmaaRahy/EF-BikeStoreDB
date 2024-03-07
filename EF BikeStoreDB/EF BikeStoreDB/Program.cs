using EF_BikeStoreDB.Data;
using EF_BikeStoreDB.Models;

namespace EF_BikeStoreDB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext context= new ApplicationDbContext();
            try {
                //var allcategories = context.Categories.ToList();
                //foreach (var item in allcategories)
                //{
                //    Console.WriteLine($"Id: {item.CategoryId}, Name: {item.CategoryName}");
                //}
                //var firstProduct=context.Products.First();
                //Console.WriteLine($"Id: {firstProduct.ProductId}, Name: {firstProduct.ProductName}, Category Id: {firstProduct.CategoryId}, Brand Id: {firstProduct.BrandId}, Year: {firstProduct.ModelYear}, Price:{firstProduct.ListPrice}");
                //var specificProduct = context.Products.Distinct();
                //foreach (var item in specificProduct)
                //{
                //Console.WriteLine($"Id: {item.ProductId}, Name: {item.ProductName}, Year: {item.ModelYear}, Price:{item.ListPrice}");

                //}
                //var resultWhere = context.Products.Where(e => e.ModelYear == 2018);
                //foreach (var item in resultWhere)
                //{
                //    Console.WriteLine($"Id: {item.ProductId}, Name: {item.ProductName}, Year: {item.ModelYear}");

                //}
                //var specificCustomer = context.Customers.Where(e => e.CustomerId ==5);
                //foreach (var item in specificCustomer)
                //{
                //    Console.WriteLine($"Id: {item.CustomerId}, Name: {item.FirstName}");

                //}
                //var result = context.Products.Select(e => new {e.ProductName, e.Brand.BrandName}).ToList();
                //foreach (var item in result)
                //{
                //    Console.WriteLine($"Product Name: {item.ProductName}    Brand Name: {item.BrandName}");
                //}

                //var CountResult = context.Products.Count(e => e.CategoryId ==2);
                //Console.WriteLine(CountResult);

                //var SumResult = context.Products.Where(e => e.CategoryId ==1).Sum(e => e.ListPrice);
                //Console.WriteLine(SumResult);

                //var AvarageResult = context.Products.Average(e => e.ListPrice);
                //Console.WriteLine(AvarageResult);

                var completedOrders = context.Orders.Where(e => e.OrderStatus == 1);
                foreach (var item in completedOrders) {
                    Console.WriteLine($"Id: {item.OrderId} , OrderState: {item.OrderStatus}");
                }



            }
            catch { }

        }
    }
}
