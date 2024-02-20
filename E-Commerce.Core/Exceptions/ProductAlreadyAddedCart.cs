namespace E_Commerce.Core.Exceptions
{
    public class ProductAlreadyAddedCart : Exception
    {
        public ProductAlreadyAddedCart() : base("Product already added to cart")
        {

        }
    }
}
