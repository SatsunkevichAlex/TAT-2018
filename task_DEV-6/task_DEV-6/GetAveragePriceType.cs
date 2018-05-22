using System;
using System.Collections.Generic;

namespace task_DEV_6
{
    /// <summary>
    /// Class part of command pattern. Get average price in interest type.
    /// </summary>
    class GetAveragePriceType : ICommand
    {
        Product product;
        public GetAveragePriceType(Product p)
        {
            product = p;
        }
        /// <summary>
        /// Execute GetAveragePrice.
        /// </summary>
        /// <param name="products"></param>
        public void Execute(List<Product> products)
        {
            product.GetAveragePriceType(products);
        }
    }
}
