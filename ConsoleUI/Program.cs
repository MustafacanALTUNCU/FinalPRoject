// See https://aka.ms/new-console-template for more information
using Business.Concrate;
using DataAccess.Concrate.InMemory;
using System;

namespace ConsoleUI // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new InMemoryProductDal());
            
            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
                Console.WriteLine();
            }
        }
    }
}
