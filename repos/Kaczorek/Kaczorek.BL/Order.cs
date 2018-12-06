using Common;
using System;
using System.Collections.Generic;

namespace Kaczorek.BL
{
    public class Order : BaseClass, ILog
    {
        #region Constructors
        public Order()
        {

        }

        public Order(int ordertId)
        {
            OrderId = ordertId;
        }
        #endregion

        #region Properties
        public int OrderId { get; private set; }
        public DateTimeOffset? DateOfOrder { get; set; }

        public List<OrderPosition> OrderPositionList { get; set; }
        public int CustomerId { get; set; }
        public int AddressDeliveryId { get; set; }
        #endregion

        #region Methods
        /// <summary>
        /// Check order data
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            var valid = true;

            if (DateOfOrder == null)
                valid = false;

            return valid;
        }

        /// <summary>
        /// Saves an order
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            // code savesaving an order
            return true;
        }

        /// <summary>
        /// download an order
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public Order Download(int orderId)
        {
            // code downloading an order
            return new Order();
        }

        /// <summary>
        /// download all orders
        /// </summary>
        /// <returns></returns>
        public List<Order> Download()
        {
            // downloading all orders
            return new List<Order>();
        }
        #endregion

        public override string ToString()
        {
            return DateOfOrder.Value.Date + " (" + OrderId + ")";
        }

        public string Log()
        {
            var log = OrderId + ": "
                + " Data: " + DateOfOrder.Value.Date
                + " Status: " + ObjectState.ToString();
            return log;
        }
    }
}
