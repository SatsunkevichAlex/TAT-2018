using System;
using System.Collections.Generic;

namespace task_DEV_6
{
    /// <summary>
    /// Class part of command pattern. Ger average price in type.
    /// </summary>
    class GetAveragePrice : ICommand
    {
        Product product;
        public GetAveragePrice(Product p)
        {
            product = p;
        }
        /// <summary>
        /// Execute GetAveragePrice.
        /// </summary>
        /// <param name="products"></param>
        public void Execute(List<Product> products)
        {
            product.GetAveragePrice(products);
        }
    }
}
