using Common;
using System.Collections.Generic;

namespace Kaczorek.BL
{
    public class Product : BaseClass, ILog
    {
        public Product()
        {

        }

        public Product(int productId)
        {
            ProductId = productId;
        }

        public decimal? ActualPrice { get; set; }
        public int ProductId { get; private set; }
        public string Description { get; set; }

        private string _productName;
        public string ProductName
        {
            get
            {
                return _productName.InsertSpace();
            }
            set { _productName = value; }
        }


        /// <summary>
        /// Check product data
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            var valid = true;

            if (string.IsNullOrWhiteSpace(ProductName) || ActualPrice == null)
                valid = false;

            return valid;
        }

        /// <summary>
        /// Saves a Product
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            // code savesaving a product
            return true;
        }

        /// <summary>
        /// download a product
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public Product Download(int productId)
        {
            // code downloading a product
            return new Product();
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

        public override string ToString()
        {
            return ProductName;
        }

        public string Log()
        {
            var log = ProductId + ": "
                + ProductName
                + " Description: " + Description
                + " Status: " + ObjectState.ToString();
            return log;
        }
    }
}
