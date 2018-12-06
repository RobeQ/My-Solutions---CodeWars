namespace Kaczorek.BL
{
    public class OrderPositionDisplay
    {
        public int OrderPositionId { get; private set; }
        public int Amount { get; set; }
        public string ProductName { get; set; }
        public decimal? ActualPrice { get; set; }
    }
}
