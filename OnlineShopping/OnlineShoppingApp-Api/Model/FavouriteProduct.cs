namespace OnlineShoppingApp.Model
{
    public class FavouriteProduct
    {
        public int ProductId { get; set; }
        public int FavId { get; set; }
        public string? ProductName { get; set; }
        public string? DescriptionOfProd { get; set; }
        public string? Image { get; set; }
        public double? Price { get; set; }
        public int Quantity { get; set; }
    }
}
