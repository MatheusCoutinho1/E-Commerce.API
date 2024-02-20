namespace E_Commerce.Core.Entities
{
    public class User : BaseEntity
    {
        public User(string fullName, string email, int phone)
        {
            FullName = fullName;
            Email = email;
            Phone = phone;
            CreatedAt = DateTime.Now;

            ClientProducts = new List<Product>();
            ShoppingCart = new List<Product>();
        }

        public string FullName { get; private set; }
        public string Email { get; private set; }
        public int Phone { get; private set; }
        public DateTime CreatedAt { get; private set; }

        public List<Product> ClientProducts { get; private set; }

        public List<Product> ShoppingCart { get; private set; }

    }
}
