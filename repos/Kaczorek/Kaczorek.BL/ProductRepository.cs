using System.Collections.Generic;

namespace Kaczorek.BL
{
    public class ProductRepository
    {
        /// <summary>
        /// download a product
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public Product Download(int productId)
        {
            // create instance of product class
            Product product = new Product(productId);

            // code downloading a customer

            // temporarily coded values, to get product
            if (productId == 5)
            {
                product.ProductName = "Miska";
                product.ActualPrice = 14.99M;
                product.Description = "Miska do zupy";
            }

            return product;
        }

        /// <summary>
        /// download all products
        /// </summary>
        /// <returns></returns>
        public List<Product> Download()
        {
            // downloading all products
            return new List<Product>();
        }

        /// <summary>
        /// Saves a Product
        /// </summary>
        /// <returns></returns>
        public bool Save(Product product)
        {
            // code savesaving a product
            var success = true;
            if(product.HaveChanges && product.DataValid)
            {
                if(product.IsNew)
                {
                    // call out insert procedure
                }
                else
                {
                    // call out update procedure
                }
            }

            return success;
        }
    }
}
