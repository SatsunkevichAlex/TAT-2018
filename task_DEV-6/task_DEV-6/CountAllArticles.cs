using System.Collections.Generic;

namespace task_DEV_6
{
    /// <summary>
    /// Class part of command pattern. Count all articles.
    /// </summary>
    class CountAllArticles : ICommand
    {
        Product product;
        public CountAllArticles(Product p)
        {
            product = p;
        }
        /// <summary>
        /// Execute GetCountAllArticles.
        /// </summary>
        /// <param name="products"></param>
        public void Execute(List<Product> products)
        {
            product.GetCountAllArticles(products);
        }
    }
}
