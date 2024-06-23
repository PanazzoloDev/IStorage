namespace IStorage.Application.Models
{
    public class NewProductOrderModel
    {
        public long ProductId { get; set; }
        public long OrderId { get; set; }
    }

    public class ViewProductOrderModel
    {
        public long Id { get; set; }
        public long ProductId { get; set; }
        public long OrderId { get; set; }
    }

    public class UpdateProductOrderModel : ViewProductOrderModel
    {

    }
}