namespace NoSolidApi.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Photo { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}
