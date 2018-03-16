
namespace OkOceanFisheries.Model.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        
        public string OriginCountry { get; set; }
        public string CatchTime { get; set; }
        public string Quantity { get; set; }
        public string Price { get; set; }
        
        public int? BuyerId { get; set; }
        public int? ProductOptionId { get; set; }
        public virtual ProductOption ProductOption { get; set; }
        public virtual Buyer Buyer { get; set; }


    }
}
