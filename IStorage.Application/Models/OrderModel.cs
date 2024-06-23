namespace IStorage.Application.Models
{
    public class NewOrderModel
    {
        public int Code { get; set; }
        public long CustomerId { get; set; }
        public string? Observations { get; set; }
        public long ResponsibleId { get; set; }
        public double Total { get; set; }
        public DateTime? Deadline { get; set; }
        public int Status { get; set; }
    }

    public class ViewOrderModel
    {
        public long Id { get; set; }
        public int Code { get; set; }
        public long CustomerId { get; set; }
        public string? Observations { get; set; }
        public long ResponsibleId { get; set; }
        public double Total { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Deleted { get; set; }
        public DateTime? Deadline { get; set; }
        public int Status { get; set; }
    }

    public class UpdateOrderModel : ViewOrderModel
    {

    }
}