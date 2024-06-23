namespace IStorage.Application.Models
{
    public class NewProductModel
    {
        public string Description { get; set; }
        public int Code { get; set; }
    }

    public class ViewProductModel
    {
        public long Id { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Deleted { get; set; }
        public int Code { get; set; }
    }

    public class UpdateProductModel : ViewProductModel
    {

    }
}