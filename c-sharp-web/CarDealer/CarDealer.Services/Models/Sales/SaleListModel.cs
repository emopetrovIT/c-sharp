namespace CarDealer.Services.Models.Sales
{
    public class SaleListModel : SaleModel
    {
        public int Id { get; set; }

        public string CustomerName { get; set; }

        public bool IsYoungDriver { get; set; }

        public decimal DiscountedPrice => 
            this.Price * (1 - (decimal)this.TotalDiscount);

        public double TotalDiscount => this.Discount + (this.IsYoungDriver ? 0.05 : 0);
    }
}
