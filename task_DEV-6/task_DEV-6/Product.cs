using System;
using System.Collections.Generic;
using System.Linq;

namespace task_DEV_6
{
    /// <summary>
    /// Product.
    /// </summary>
    class Product
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public double CostPerUnit { get; set; }
        public Product()
        {
            this.Type = Console.ReadLine();
            this.Name = Console.ReadLine();
            this.Count = Convert.ToInt16(Console.ReadLine());
            this.CostPerUnit = Convert.ToDouble(Console.ReadLine());
        }
        /// <summary>
        /// Add product.
        /// </summary>
        /// <param name="product"></param>
        /// <param name="list of products"></param>
        /// <returns>List of products.</returns>
        public List<Product> AddProduct(Product product, List<Product> products)
        {
            while (Console.ReadKey(true).Key != ConsoleKey.Escape)
            {
                products.Add(new Product());
            }
            return products;
        }
        /// <summary>
        /// Get count of types.
        /// </summary>
        /// <param name="products"></param>
        /// <returns>Count of types.</returns>
        public int GetCountTypes(List<Product> products) // I don't know why but all methods below ignore first element in list products.
        {
            int countTypes = products.GroupBy(p => p.Type).Select(group => group.First()).Count();       
            Console.WriteLine("Count of types = " + countTypes);
            return countTypes;
        }
        /// <summary>
        /// Get count of all articles.
        /// </summary>
        /// <param name="products"></param>
        /// <returns>cout of all articles.</returns>
        public int GetCountAllArticles(List<Product> products)
        {
            int countAllArticles = products.Sum(p => p.Count);
            Console.WriteLine("Count off all articles = " + countAllArticles);
            return countAllArticles;
        }
        /// <summary>
        /// Get average price of article.
        /// </summary>
        /// <param name="products"></param>
        /// <returns>average price of article.</returns>
        public double GetAveragePrice(List<Product> products)
        {
            double averagePrice = products.Average(p => p.CostPerUnit);
            Console.WriteLine("Average price of article = " + averagePrice);
            return averagePrice;
        }
        /// <summary>
        /// Get Average price of type.
        /// </summary>
        /// <param name="products"></param>
        /// <returns>average price of type.</returns>
        public double GetAveragePriceType(List<Product> products)
        {
            Console.WriteLine("Input interest type");
            string interstType = Console.ReadLine();
            double averagePriceType = products.Where(p => p.Type == interstType).Average(p => p.CostPerUnit);
            Console.WriteLine("Average price of article in interest type = " + averagePriceType);
            return averagePriceType;
        }
    }
}
