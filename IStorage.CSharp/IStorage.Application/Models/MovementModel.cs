namespace IStorage.Application.Models
{
    public class NewMovementModel
    {
        public long SupplyId { get; set; }
        public double Quantity { get; set; }
        public string Type { get; set; }
        public long? SourceWarehouseId { get; set; }
        public long? DestinationWarehouseId { get; set; }
        public string? Observations { get; set; }
        public long? OrderId { get; set; }
    }

    public class ViewMovementModel
    {
        public long Id { get; set; }
        public long SupplyId { get; set; }
        public double Quantity { get; set; }
        public string Type { get; set; }
        public long? SourceWarehouseId { get; set; }
        public long? DestinationWarehouseId { get; set; }
        public string? Observations { get; set; }
        public DateTime CreatedAt { get; set; }
        public long? OrderId { get; set; }
    }

    public class UpdateMovementModel : ViewMovementModel
    {

    }
}