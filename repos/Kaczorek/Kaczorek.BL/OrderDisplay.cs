using System;
using System.Collections.Generic;

namespace Kaczorek.BL
{
    public class OrderDisplay
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTimeOffset DateOfOrder { get; set; }
        public List<OrderPositionDisplay> OrderPositionDisplayList { get; set; }
        public int OrderId { get; set; }
        public Address AddressOrder { get; set; }
    }
}
