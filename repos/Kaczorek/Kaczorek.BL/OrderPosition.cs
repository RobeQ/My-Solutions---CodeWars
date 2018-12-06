using System.Collections.Generic;

namespace Kaczorek.BL
{
    public class OrderPosition
    {
        public OrderPosition()
        {

        }

        public OrderPosition(int orderPositionId)
        {
            OrderPositionId = orderPositionId;
        }

        public int OrderPositionId { get; private set; }
        public int Amount { get; set; }
        public int ProductId { get; set; }
        public decimal? PriceOfPurchase { get; set; }

        /// <summary>
        /// Check position order data
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var valid = true;

            if (PriceOfPurchase == 0 || Amount <= 0 || ProductId <= 0)
                valid = false;

            return valid;
        }

        /// <summary>
        /// Saves an position order
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            // code savesaving an position order
            return true;
        }

        /// <summary>
        /// download an position order
        /// </summary>
        /// <param name="orderPositionId"></param>
        /// <returns></returns>
        public OrderPosition Download(int orderPositionId)
        {
            // code downloading an position order
            return new OrderPosition();
        }

        /// <summary>
        /// download all position orders
        /// </summary>
        /// <returns></returns>
        public List<OrderPosition> Download()
        {
            // downloading all position orders
            return new List<OrderPosition>();
        }
    }
}
