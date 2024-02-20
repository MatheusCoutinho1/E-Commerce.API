using E_Commerce.Core.Enums;

namespace E_Commerce.Core.Entities
{
    public  class Product : BaseEntity
    {
        public Product(string name, int idClient, int idShoppingCart, decimal value, int amount, string description)
        {
            Name = name;
            IdClient = idClient;
            IdShoppingCart = idShoppingCart;
            Value = value;
            Amount = amount;
            Description = description;

            Status = ProductStatusEnum.AwaitingPayment;
            Comments = new List<ProjectComment>();
        }

        public string Name { get; private set; }
        public int IdClient { get; private set; }
        public int IdShoppingCart { get; private set; }
        public decimal Value { get; private set; }
        public int Amount { get; private set; }
        public string Description { get; private set; }
        public ProductStatusEnum Status { get; private set; }
        public List<ProjectComment> Comments { get; private set; }
    }
}
