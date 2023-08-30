public class Cart
{
        public int CartId { get; set; }
        public List<CartItem> CartItems { get; set; } = new List<CartItem>();
        public decimal TotalPrice
        {
            get
            {
                decimal totalPrice = 0;
                foreach (var item in CartItems)
                {
                    totalPrice += (decimal)item.Product.Price * item.Quantity;
                }
                return totalPrice;
            }
    }
}