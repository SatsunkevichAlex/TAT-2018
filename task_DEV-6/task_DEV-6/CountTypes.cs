using System.Collections.Generic;

namespace task_DEV_6
{
    /// <summary>
    /// Class part of command pattern. Count types.
    /// </summary>
    class CountTypes : ICommand
    {
        Product product;
        public CountTypes(Product p)
        {
            product = p;
        }
        /// <summary>
        /// Execute GetCountTypes.
        /// </summary>
        /// <param name="products"></param>
        public void Execute(List<Product> products)
        {
            product.GetCountTypes(products);
        }
    }
}
