namespace E_commerce.API.Models
{
    public class CreateProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
        public int Amount { get; set; }
        public string Description { get; set; }
        public DateTime Sale { get; set; }
        public DateTime Replacement { get; set; }
    }
}
