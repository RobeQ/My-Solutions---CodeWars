using System;
using System.Collections.Generic;

namespace Kaczorek.BL
{
    public class OrderRepository
    {
        /// <summary>
        /// download an order
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public Order Download(int orderId)
        {
            // create instance of order class
            Order order = new Order(orderId);

            // code downloading an order

            // temporairrly coded values, to get order
            if (orderId == 10)
            {
                order.DateOfOrder = new DateTimeOffset(2018, 4, 20, 11, 00, 00, new TimeSpan(7, 0, 0));
            }

            return order;
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

        /// <summary>
        /// Saves a Product
        /// </summary>
        /// <returns></returns>
        public bool Save(Order order)
        {
            // code savesaving a product
            var success = true;
            if (order.HaveChanges && order.DataValid)
            {
                if (order.IsNew)
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

        /// <summary>
        /// download one order to display
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public OrderDisplay DownloadOrderToDisplay(int orderId)
        {
            OrderDisplay orderDisplay = new OrderDisplay();

            // code that downloading order area

            // temporairly data code
            if(orderId == 10)
            {
                orderDisplay.Name = "Ralph";
                orderDisplay.Surname = "Nowak";
                orderDisplay.DateOfOrder = new DateTimeOffset(2018, 05, 21, 12, 00, 00, new TimeSpan(5, 0, 0));
                orderDisplay.AddressOrder = new Address()
                {
                    AddressType = 2,
                    Country = "Poland",
                    Street = "Jasna",
                    ZipCode = "44-432",
                    Town = "Wroclaw"
                };
                orderDisplay.OrderPositionDisplayList = new List<OrderPositionDisplay>();

                // code that downloading order area

                // temporairly data code
                if(orderId == 10)
                {
                    var orderPositionDisplay = new OrderPositionDisplay()
                    {
                        ProductName = "Krzeslo",
                        ActualPrice = 45.66M,
                        Amount = 5
                    };
                    orderDisplay.OrderPositionDisplayList.Add(orderPositionDisplay);

                    orderPositionDisplay = new OrderPositionDisplay()
                    {
                        ProductName = "Stolik",
                        ActualPrice = 100.34M,
                        Amount = 2
                    };
                    orderDisplay.OrderPositionDisplayList.Add(orderPositionDisplay);
                }
            }

            return orderDisplay;
        }
    }
}
