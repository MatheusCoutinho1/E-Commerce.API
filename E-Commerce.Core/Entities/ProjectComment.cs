namespace E_Commerce.Core.Entities
{
    public class ProjectComment : BaseEntity
    {
        public ProjectComment(string content, int idProduct, int idUser)
        {
            Content = content;
            IdProduct = idProduct;
            IdUser = idUser;
        }

        public string Content { get; private set; }
        public int IdProduct { get; private set; }
        public int IdUser { get; private set; }
        public DateTime CreatedAt { get; private set; }
    }
}
