namespace IStorage.Application.Models
{
    public class NewInventoryModel
    {
        public long SupplyId { get; set; }
        public double Quantity { get; set; }
        public long WarehouseId { get; set; }
    }

    public class ViewInventoryModel
    {
        public long Id { get; set; }
        public long SupplyId { get; set; }
        public double Quantity { get; set; }
        public long WarehouseId { get; set; }
    }

    public class UpdateInventoryModel : ViewInventoryModel
    {

    }
}