using System;
using System.Collections.Generic;

namespace task_DEV_6
{
    class EntryPoint
    {
        static void Main(string[] args)
        { 
            Product product = new Product();

            List<Product> products = new List<Product>();
            product.AddProduct(product, products);

            Invoker invoker = new Invoker();

            CountTypes countTypes = new CountTypes(product);
            CountAllArticles countAllArticles = new CountAllArticles(product);
            GetAveragePrice getAveragePrice = new GetAveragePrice(product);
            GetAveragePriceType getAveragePriceType = new GetAveragePriceType(product);

            invoker.SetCommand(countTypes);
            invoker.Run(products);
            invoker.SetCommand(countAllArticles);
            invoker.Run(products);
            invoker.SetCommand(getAveragePrice);
            invoker.Run(products);
            invoker.SetCommand(getAveragePriceType);
            invoker.Run(products);
        }
    }
}