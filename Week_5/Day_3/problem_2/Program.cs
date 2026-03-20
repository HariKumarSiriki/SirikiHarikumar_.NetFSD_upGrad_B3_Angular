using ConsoleApp1;
using System;

using System.Collections.Generic;
class Program
{
    
        static void Main()
        {
            Product product = new Product();
            var products = product.GetProducts();
        //1
        var result = from p in products
                     where p.ProCategory == "FMCG"
                     select p;

        //2
        //var result = from p in products
        //             where p.ProCategory == "Grain"
        //             select p;

        //3
        //var result = from p in products
        //             orderby p.ProCode
        //             select p;

        //4
        //var result = from p in products
        //             orderby p.ProCategory
        //             select p;

        //5
        //var result = from p in products
        //             orderby p.ProMrp
        //             select p;


        //6
        //var result = from p in products
        //             orderby p.ProMrp descending
        //             select p;

        //7
        //var result = from p in products
        //             group p by p.ProCategory;

        //8
        //var result = from p in products
        //             group p by p.Mrp;

        //9
        //var result = (from p in products
        //              where p.Category == "FMCG"
        //              orderby p.Mrp descending
        //              select p).FirstOrDefault();

        //10
        //var result = from p in products
        //             select p;

        //int count = result.Count();
        //Console.WriteLine(count);


        //11
        //var result = from p in products
        //             where p.Category == "FMCG"
        //             select p;

        //int count = result.Count();
        //Console.WriteLine(count);

        //12
        //var result = from p in products
        //             select p.Mrp;

        //int maxPrice = result.Max();
        //Console.WriteLine(maxPrice);

        foreach (var item in result)
            {
                Console.WriteLine($"{item.ProCode}\t{item.ProName}\t{item.ProMrp}");
            }

            Console.ReadLine();
        }
    
}
